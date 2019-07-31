﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using dnlib.DotNet;

namespace Rhydon.Core.HeapParser
{
    public class KoiHeader
    {
        public KoiHeader(RhydonContext ctx)
        {
            ctx.Logger.Debug("Looking for #Koi stream...");
            var heap = ctx.Module.Metadata.AllStreams.SingleOrDefault(s => s.Name == "#Koi");
            if (heap == null)
            {
                ctx.Logger.Error("#Koi stream not found...");
                return;
            }


            ctx.Logger.Info("Parsing KoiVM header");
            ctx.Reader = new BinaryReader(heap.CreateReader().AsStream());

            var magic = ctx.ReadUInt32();
            if (magic != 0x68736966)
                ctx.Logger.Warning($"Magic wasn't 'fish' (0x68736966), instead: 0x{magic:X}");

            var refCount = (int) ctx.ReadUInt32();
            var strCount = (int) ctx.ReadUInt32();
            var metCount = (int) ctx.ReadUInt32();
            ctx.Logger.Debug(refCount.ToString());
            ctx.Logger.Debug(strCount.ToString());
            ctx.Logger.Debug(metCount.ToString());

            References = new Dictionary<uint, IMemberRef>(refCount);
            Strings = new Dictionary<uint, string>(strCount);
            Methods = new Dictionary<uint, MethodEntry>(metCount);

            ReadReferences(ctx, refCount);
            ctx.Logger.Success($"Parsed {refCount} references");

            ReadStrings(ctx, strCount);
            ctx.Logger.Success($"Parsed {strCount} strings");

            ReadMethods(ctx, metCount);
            ctx.Logger.Success($"Parsed {metCount} exports");

            ReadConstants(ctx);
            ctx.Logger.Success($"Parsed {KoiOpCodes.Count()} constants");
            Good = true;
        }

        void ReadReferences(RhydonContext ctx, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var id = ctx.ReadCompressedUint();
                var token = FromCodedToken(ctx.ReadCompressedUint());
                var resolved = (IMemberRef) ctx.Module.ResolveToken(token);

                ctx.Logger.Debug($"Reference[{id:D3}]: Token: 0x{token:X} | MemberRef: {resolved.FullName}");
                References[id] = resolved;
            }
        }

        void ReadStrings(RhydonContext ctx, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var id = ctx.ReadCompressedUint();
                var len = (int) ctx.ReadCompressedUint() << 1;
                var str = Encoding.Unicode.GetString(ctx.ReadBytes(len));

                ctx.Logger.Debug($"Strings[{id:D3}]: \"{str}\"");
                Strings[id] = str;
            }
        }

        void ReadMethods(RhydonContext ctx, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var id = ctx.ReadCompressedUint();
                var export = MethodEntry.Create(ctx);

                ctx.Logger.Debug($"Methods[{id:D3}]: Offset: 0x{export.Offset:X8} Key: 0x{export.Key:X8}");
                Methods[id] = export;
            }
        }

        void ReadConstants(RhydonContext ctx)
        {
            foreach (var type in ctx.Module.Types)
            {
                if (!type.HasFields)
                    continue;
                if (type.Fields.Count != 119)
                    continue;
                var methods = type.Methods;
                Dictionary<FieldDef, int> list = new Dictionary<FieldDef, int>();
                var method = methods[0];
                for (int i = 0; i < method.Body.Instructions.Count(); i++)
                {
                    if (method.Body.Instructions[i].IsLdcI4())
                    {
                        if (method.Body.Instructions[i + 1].OpCode == dnlib.DotNet.Emit.OpCodes.Stfld)
                        {
                            int value = method.Body.Instructions[i].GetLdcI4Value();
                            FieldDef field = (FieldDef) method.Body.Instructions[i + 1].Operand;
                            if (list.ContainsKey(field))
                            {
                                list[field] = value;
                            }
                            else
                            {
                                list.Add(field, value);
                            }
                        }
                    }
                }
                var fields = type.Fields.OrderBy(c => c.MDToken.Raw).ToList();
                KoiOpCodes = new Dictionary<FieldDef, int>();
                foreach (var field in fields)
                {
                    int lol;
                    list.TryGetValue(field, out lol);
                    if (KoiOpCodes.ContainsKey(field))
                    {
                        KoiOpCodes[field] = lol;
                    }
                    else
                    {
                        KoiOpCodes.Add(field, lol);
                    }
                }
               // foreach (var fld in KoiOpCodes)
               //     ctx.Logger.Debug(fld.Key.Name + " " + fld.Value);
            }
        }

        public bool Good { get; }

        public Dictionary<FieldDef, int> KoiOpCodes;
        public readonly Dictionary<uint, IMemberRef> References;
        public readonly Dictionary<uint, string> Strings;
        public readonly Dictionary<uint, MethodEntry> Methods;

        public static uint FromCodedToken(uint codedToken)
        {
            var rid = codedToken >> 3;
            switch (codedToken & 7)
            {
                case 1:
                    return rid | 0x02000000;
                case 2:
                    return rid | 0x01000000;
                case 3:
                    return rid | 0x1b000000;
                case 4:
                    return rid | 0x0a000000;
                case 5:
                    return rid | 0x06000000;
                case 6:
                    return rid | 0x04000000;
                case 7:
                    return rid | 0x2b000000;
                default:
                    return rid;
            }
        }
    }
}
