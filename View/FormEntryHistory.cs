using ParkEase.Controller;
using ParkEase.Model.Entity;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class FormEntryHistory : Form
    {
        public event LoadDataEvenHandler? OnLoadData;
        private HistoryController _controller;
        private VehicleTypeController _vehicleTypeController;
        private LocationController _locationController;
        private VehicleType[] _vehicleType = {};
        private Location[] _location = {};

        public FormEntryHistory()
        {
            InitializeComponent();
            _controller = new HistoryController();
            _vehicleTypeController = new VehicleTypeController();
            _locationController = new LocationController();
            ucTopBar.SetForm(this);
            ucTopBar.HideMaximize();
            dragControl.TargetControl = ucTopBar.GetPanel();
            InitializeVehicleType();
            InitializeLocation();
        }

        private void InitializeVehicleType()
        {
            var param = new BaseRequestPagination()
            {
                Limit = App.DEFAULT_MAX_PAGINATION_LIMIT,
                Page = 1,
            };

            try
            {
                var data = _vehicleTypeController.GetAllVehicleType(param);
                var content = data?.Data?.Content;
                if (content != null) _vehicleType = content;
                foreach (var vehicleType in _vehicleType)
                {
                    cmbVehicleType.Items.Add(vehicleType.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitializeLocation()
        {
            var param = new BaseRequestPagination<LocationFilterRequest>()
            {
                Limit = App.DEFAULT_MAX_PAGINATION_LIMIT,
                Page = 1,
                Additional = new LocationFilterRequest()
                {
                    IsExit = false,
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
            string vehicleNumber = txtVehicleNumber.Text.Trim();
            string vehicleType = "";
            int vehicleTypeIdx = cmbVehicleType.SelectedIndex;
            if (vehicleTypeIdx >= 0 && vehicleTypeIdx < _vehicleType.Length)
            {
                vehicleType = _vehicleType[vehicleTypeIdx].Code;
            }
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
                _controller.CreateEntryHistory(location, vehicleNumber, vehicleType);
                if (OnLoadData != null) OnLoadData();
                DialogResult dialog = MessageBox.Show("Success add Entry History", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
