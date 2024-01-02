namespace ParkEase.UserControls
{
    public partial class UC_TopBar : UserControl
    {
        private Form? _form = null;

        public UC_TopBar()
        {
            InitializeComponent();
            this.Close.Location = new Point(this.Width - 32, 8);
            this.Maximize.Location = new Point(this.Width - 66, 8);
            this.Minimize.Location = new Point(this.Width - 100, 8);
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
            this.Minimize.Location = new Point(this.Width - 66, 8);
            this.Maximize.Hide();
        }

        public Panel GetPanel()
        {
            return pnlTopBar;
        }
    }
}
