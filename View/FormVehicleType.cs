using Guna.UI2.AnimatorNS;
using ParkEase.Controller;
using ParkEase.Model.Entity;

namespace ParkEase.View
{
    public partial class FormVehicleType : Form
    {
        public event LoadDataEvenHandler? OnLoadData;
        private bool isCreate = false;
        private VehicleTypeController _controller;

        public FormVehicleType()
        {
            InitializeComponent();
            _controller = new VehicleTypeController();
            ucTopBar.SetForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string price = txtPrice.Text.Trim();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                if (isCreate)
                {
                    _controller.CreateVehicleType(code, name, price);
                }
                else
                {
                    _controller.UpdateVehicleType(code, name, price);
                }

                string message = "Success add Vehicle Type";
                if (!isCreate) message = "Success update Vehicle Type";
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
                Text = "Add Vehicle Type";
                lblTitle.Text = "ADD VEHICLE TYPE";
                btnSave.Text = "Add";
                return;
            }

            Text = "Update Vehicle Type";
            lblTitle.Text = "UPDATE VEHICLE TYPE";
            btnSave.Text = "Save";
            return;
        }

        public void SetData(VehicleType data)
        {
            txtCode.Text = data.Code;
            txtName.Text = data.Name;
            txtPrice.Text = data.Price.ToString();
        }
    }
}
