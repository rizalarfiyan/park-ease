using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ParkEase.UserControls
{
    public partial class UC_TopBar : UserControl
    {
        public UC_TopBar()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form parentForm)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
