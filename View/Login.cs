using ParkEase.Constants;
using ParkEase.Controller;

namespace ParkEase.View
{
    public partial class frmLogin : Form
    {
        private AuthController _controller;

        public frmLogin()
        {
            InitializeComponent();
            this.Text = $"{App.APP_NAME} - Login";
            _controller = new AuthController();
            ucTopBar.HideMaximize();
            dragControl.TargetControl = ucTopBar.GetPanel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            btnLogin.Enabled = false;

            try
            {
                _controller.Login(username, password);
                var dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnLogin.Enabled = true;
                txtPassword.Text = "";
            }
        }
    }
}
