using ParkEase.Controller;
using ParkEase.Model.Entity;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class FormUser : Form
    {
        public event LoadDataEvenHandler? OnLoadData;
        private bool isCreate = false;
        private UserController _controller;
        private int _userId;

        public FormUser()
        {
            InitializeComponent();
            _controller = new UserController();
            ucTopBar.SetForm(this);
            ucTopBar.HideMaximize();
            FillCombobox();
            dragControl.TargetControl = ucTopBar.GetPanel();
        }

        private void FillCombobox()
        {
            foreach (var role in App.LIST_ROLE)
            {
                cmbRole.Items.Add(role);
            }

            foreach (var status in App.LIST_STATUS)
            {
                cmbStatus.Items.Add(status);
            }

            cmbRole.SelectedIndex = App.DEFAULT_ROLE_IDX;
            cmbStatus.SelectedIndex = App.DEFAULT_STATUS_IDX;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string name = txtName.Text.Trim();
            string role = cmbRole.Text;
            string status = cmbStatus.Text;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                if (isCreate)
                {
                    _controller.CreateUser(username, password, name, role, status);
                }
                else
                {
                    _controller.UpdateUser(username, password, name, role, status, _userId);
                }

                string message = "Success add User";
                if (!isCreate) message = "Success update User";
                if (OnLoadData != null) OnLoadData();

                DialogResult dialog = MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void IsCreate(bool isCreate)
        {
            this.isCreate = isCreate;
            if (isCreate)
            {
                Text = "Add User";
                lblTitle.Text = "ADD USER";
                btnSave.Text = "Add";
                return;
            }

            Text = "Update User";
            lblTitle.Text = "UPDATE USER";
            btnSave.Text = "Save";
            return;
        }

        public void SetData(User data)
        {
            txtUsername.Text = data.Username;
            txtName.Text = data.Name;
            cmbRole.SelectedIndex = cmbRole.Items.IndexOf(data.Role);
            cmbStatus.SelectedIndex = cmbStatus.Items.IndexOf(data.Status);
            _userId = data.Id;
        }
    }
}
