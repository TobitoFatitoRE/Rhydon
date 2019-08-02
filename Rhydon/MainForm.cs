using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rhydon {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        #region Custom titlebar
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd,
            int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        private void TitleBarDrag(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }
        #endregion

        #region Opacity while moving window
        private static bool _isMoving;
        private void MainWindow_ResizeBegin(object sender, EventArgs e) =>
            _isMoving = true;

        private void MainWindow_ResizeEnd(object sender, EventArgs e) =>
            _isMoving = false;

        private void OpacityTimer_Tick(object sender, EventArgs e) {
            if (_isMoving) {
                if (Opacity > 0.40)
                    Opacity -= 0.03;
            } else {
                if (Opacity < 1)
                    Opacity += 0.04;
            }
        }
        #endregion

        #region Background color
        private readonly Color _start = Color.FromArgb(255, 64, 64, 64);
        private readonly Color _end = Color.FromArgb(255, 160, 32, 32);
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (var brush = new LinearGradientBrush(ClientRectangle, _start, _end, 90F)) {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
        #endregion

        #region Custom close/minimize buttons
        private void BtnClose_Click(object sender, EventArgs e) =>
            Close();

        private void BtnMinimize_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;
    #endregion
    }
}
