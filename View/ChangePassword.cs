using Guna.UI2.AnimatorNS;
using ParkEase.Controller;

namespace ParkEase.View
{
    public partial class frmChangePassword : Form
    {
        private UserController _controller;

        public frmChangePassword()
        {
            InitializeComponent();
            InitializeApp();
            _controller = new UserController();
        }

        private void InitializeApp()
        {
            ucTopBar.SetForm(this);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text.Trim();
            string password = txtPassword.Text.Trim();
            string passwordConfirmation = txtPasswordConfirmation.Text.Trim();
            btnChangePassword.Enabled = false;

            try
            {
                _controller.ChangePassword(oldPassword, password, passwordConfirmation);
                DialogResult dialog = MessageBox.Show("Password has been change, you can use new password in next login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnChangePassword.Enabled = true;
            }
        }
    }
}
