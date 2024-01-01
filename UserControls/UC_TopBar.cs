using System.Runtime.InteropServices;

namespace ParkEase.UserControls
{
    public partial class UC_TopBar : UserControl
    {
        private Form? _form = null;

        public UC_TopBar()
        {
            InitializeComponent();
        }

        public void SetForm(Form form)
        {
            _form = form;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form parentForm)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form parentForm)
            {
                if (parentForm.WindowState == FormWindowState.Normal)
                {
                    parentForm.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    parentForm.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Close();
                return;
            }

            Application.Exit();
        }

        public void HideMaximize()
        {
            this.Minimize.Location = new Point(844, 8);
            this.Maximize.Hide();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.Print("OK");

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public Panel GetPanel()
        {
            return pnlTopBar;
        }
    }
}
