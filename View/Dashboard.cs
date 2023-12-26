using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Text = $"{App.APP_NAME} - Dashboard";
            InitializeHeader();
        }

        private void InitializeHeader()
        {
            ucHeader.SetAvatar(Program.UserData?.Name ?? "AZ");
            ucHeader.SetUsername(Program.UserData?.Username ?? "username");
            ucHeader.SetRole(Program.UserData?.Role ?? "admin");
        }

        private void MoveImageBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            imgSlide.Location = new Point(btn.Location.X + 58, btn.Location.Y - 22);
            imgSlide.SendToBack();
        }

        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageBox(sender);
        }
    }
}
