using ParkEase.Model.Entity;

namespace ParkEase.View
{
    public partial class FormVehicleType : Form
    {
        public event LoadDataEvenHandler? OnLoadData;

        public FormVehicleType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void IsCreate(bool isCreate)
        {
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
