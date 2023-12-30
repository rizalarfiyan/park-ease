using ParkEase.Controller;
using ParkEase.Model.Entity;

namespace ParkEase.View
{
    public partial class FormLocation : Form
    {
        public event LoadDataEvenHandler? OnLoadData;
        private bool isCreate = false;
        private LocationController _controller;

        public FormLocation()
        {
            InitializeComponent();
            _controller = new LocationController();
            ucTopBar.SetForm(this);
            ucTopBar.HideMaximize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            bool isExit = chbExit.Checked;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                if (isCreate)
                {
                    _controller.CreateLocation(code, name, isExit);
                }
                else
                {
                    _controller.UpdateLocation(code, name, isExit);
                }

                string message = "Success add Location";
                if (!isCreate) message = "Success update Location";
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
                Text = "Add Location";
                lblTitle.Text = "ADD LOCATION";
                btnSave.Text = "Add";
                return;
            }

            Text = "Update Location";
            lblTitle.Text = "UPDATE LOCATION";
            btnSave.Text = "Save";
            txtCode.Enabled = false;
            return;
        }

        public void SetData(Location data)
        {
            txtCode.Text = data.Code;
            txtName.Text = data.Name;
            chbExit.Checked = data.IsExit;
        }
    }
}
