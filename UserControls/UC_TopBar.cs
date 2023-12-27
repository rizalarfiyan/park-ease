using System.Windows.Forms;

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
            this.Minimize.Location = new Point(856, 8);
            this.Maximize.Hide();
        }
    }
}
