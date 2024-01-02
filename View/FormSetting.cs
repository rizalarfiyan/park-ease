using ParkEase.Controller;
using ParkEase.Model.Entity;

namespace ParkEase.View
{
    public partial class FormSetting : Form
    {
        protected SettingController _controller;
        protected Setting _content;

        public FormSetting()
        {
            InitializeComponent();
            _controller = new SettingController();
            LoadData();
        }

        protected void LoadData()
        {
            try
            {
                var data = _controller.GetSetting();
                var content = data?.Data;
                if (content != null) _content = content;
                RenderData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void RenderData()
        {
            txtFineTicketCalculation.Text = _content.FineTicketCalculation.ToString();
            txtNextHourCalculation.Text = _content.NextHourCalculation.ToString();
            txtMaxCapacity.Text = _content.MaxCapacity.ToString();

            string fineDescription = _content.FineTicketCalculationDescription;
            if (string.IsNullOrEmpty(fineDescription)) fineDescription = "No note";
            lblFineTicketCalculationDescription.Text = fineDescription;

            string nextHourDescription = _content.NextHourCalculationDescription;
            if (string.IsNullOrEmpty(nextHourDescription)) nextHourDescription = "No note";
            lblNextHourCalculationDescription.Text = nextHourDescription;

            string maxCapacityDescription = _content.NextHourCalculationDescription;
            if (string.IsNullOrEmpty(maxCapacityDescription)) maxCapacityDescription = "No note";
            lblMaxCapacityDescription.Text = maxCapacityDescription;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RenderData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fineTicketCalculation = txtFineTicketCalculation.Text.Trim();
            string nextHourCalculation = txtNextHourCalculation.Text.Trim();
            string maxCapacity = txtMaxCapacity.Text.Trim();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                _controller.CreateOrUpdateSetting(fineTicketCalculation, nextHourCalculation, maxCapacity);
                string message = "Success Update Setting";
                LoadData();
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
