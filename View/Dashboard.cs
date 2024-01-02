using Guna.UI2.WinForms;
using ParkEase.Constants;
using ParkEase.Controller;

namespace ParkEase.View
{
    public partial class frmDashboard : Form
    {
        private Form? activeForm = null;
        private AuthController _controller;

        public frmDashboard()
        {
            InitializeComponent();
            this.Text = $"{App.APP_NAME} - Dashboard";
            _controller = new AuthController();
            InitializeHeader();
            InitializeRole();
            dragControl.TargetControl = ucTopBar.GetPanel();
            ShowDashboardAnalytics();
            changeLogoutLocation();
        }

        private void InitializeHeader()
        {
            ucHeader.SetAvatar(Program.UserData?.Name ?? "Paijo Royo");
            ucHeader.SetUsername(Program.UserData?.Username ?? "username");
            ucHeader.SetRole(Program.UserData?.Role ?? "karyawan");
        }

        private void InitializeRole()
        {
            if (Program.UserData?.Role != "admin")
            {
                btnUsers.Hide();
                btnLocation.Hide();
                btnVehicleType.Hide();
                btnSettings.Hide();
            }
        }

        private void ShowDashboardAnalytics()
        {
            openChildForm(new DashboardAnalytics());
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

        private void frmDashboard_SizeChanged(object sender, EventArgs e)
        {
            if (btnDashboard.Checked)
            {
                MoveImageBox(btnDashboard);
            }
            else if (btnPark.Checked)
            {
                MoveImageBox(btnPark);
            }
            else if (btnUsers.Checked)
            {
                MoveImageBox(btnUsers);
            }
            else if (btnLocation.Checked)
            {
                MoveImageBox(btnLocation);
            }
            else if (btnVehicleType.Checked)
            {
                MoveImageBox(btnVehicleType);
            }
            else if (btnSettings.Checked)
            {
                MoveImageBox(btnSettings);
            }
            changeLogoutLocation();
        }

        private void changeLogoutLocation()
        {
            btnLogOut.Location = new Point(26, this.Height - 120);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            openChildForm(new TableVehicleType());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new TableUser());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.UserData = null;
            Program.UserToken = null;
            _controller.RemovePersistanceAuth();
            var login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new TableLocation());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSetting());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardAnalytics();
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            openChildForm(new TableHistory());
        }
    }
}
