using ParkEase.Controller;
using ParkEase.Model.Entity;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class FormFineHistory : Form
    {
        public event LoadDataEvenHandler? OnLoadData;
        private HistoryController _controller;
        private LocationController _locationController;
        private Location[] _location;
        private string _entryHistoryId;
        private int _price;

        public FormFineHistory()
        {
            InitializeComponent();
            _controller = new HistoryController();
            _locationController = new LocationController();
            ucTopBar.SetForm(this);
            ucTopBar.HideMaximize();
            dragControl.TargetControl = ucTopBar.GetPanel();
            InitializeLocation();
        }

        private void InitializeLocation()
        {
            var param = new BaseRequestPagination<LocationFilterRequest>()
            {
                Limit = App.DEFAULT_MAX_PAGINATION_LIMIT,
                Page = 1,
                Additional = new LocationFilterRequest()
                {
                    IsExit = true,
                }
            };

            try
            {
                var data = _locationController.GetAllLocation(param);
                var content = data?.Data?.Content;
                if (content != null) _location = content;
                foreach (var location in _location)
                {
                    cmbLocation.Items.Add(location.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string identity = txtlIdentityKTP.Text.Trim();
            string vehicleIdentity = txtIdentitySIM.Text.Trim();
            string address = txtAddress.Text.Trim();
            string description = txtReason.Text.Trim();
            string location = "";
            int locationIdx = cmbLocation.SelectedIndex;
            if (locationIdx >= 0 && locationIdx < _location.Length)
            {
                location = _location[locationIdx].Code;
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                _controller.CreateFineHistory(_entryHistoryId, location, _price, name, identity, vehicleIdentity, address, description);
                if (OnLoadData != null) OnLoadData();
                DialogResult dialog = MessageBox.Show("Success change to Fine History", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void SetData(History data)
        {
            _entryHistoryId = data.Id;
            txtVehicleNumber.Text = data.VehicleNumber;
        }

        public void GetPrice()
        {
            try
            {
                var data = _controller.CalculateHistory(_entryHistoryId, true);
                var content = data?.Data;
                if (content != null) _price = (int)content;
                txtPrice.Text = _price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void onPayChange(object sender, EventArgs e)
        {
            int pay = 0;
            try
            {
                pay = Int32.Parse(txtPay.Text);
            }
            catch (FormatException)
            {
                pay = 0;
            }

            txtChange.Text = (pay - _price).ToString();
        }
    }
}
