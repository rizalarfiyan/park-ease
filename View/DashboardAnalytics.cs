using Guna.Charts.WinForms;
using ParkEase.Constants;
using ParkEase.Controller;
using ParkEase.Model.Entity;
using System;

namespace ParkEase.View
{
    public partial class DashboardAnalytics : Form
    {
        protected HistoryController _controller;
        protected string _timeFrequency;
        protected HistoryStatistic _content;

        public DashboardAnalytics()
        {
            InitializeComponent();
            _controller = new HistoryController();
            FillCombobox();
            UpdateData();
        }

        private void FillCombobox()
        {
            foreach (var timeFrequency in App.LIST_TIME_FREQUENCY)
            {
                cmbTimeFrequency.Items.Add(timeFrequency);
            }

            cmbTimeFrequency.SelectedIndex = App.DEFAULT_TIME_FREQUENCY_IDX;
        }

        private void UpdateData()
        {
            try
            {
                var data = _controller.HistoryStatistic(_timeFrequency);
                var content = data?.Data;
                if (content != null) _content = content;
                UpdateChart();
                UpdateCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateChart()
        {
            if (_content.Charts.Length <= 0) return;
            dataRevenue.DataPoints.Clear();
            dataVehicle.DataPoints.Clear();
            foreach (var chart in _content.Charts)
            {
                dataRevenue.DataPoints.Add(chart.Name, chart.Revenue);
                dataVehicle.DataPoints.Add(chart.Name, chart.Vehicle);
            }
            dataRevenue.PointRadius = 3;
            dataRevenue.PointStyle = PointStyle.Circle;
            dataVehicle.PointRadius = 3;
            dataVehicle.PointStyle = PointStyle.Circle;
            chartDashboard.Datasets.Add(dataRevenue);
            chartDashboard.Datasets.Add(dataVehicle);
            chartDashboard.Update();
        }

        private void UpdateCard()
        {
            cardTotalRevenue.CardValue = _content.RevenueTotal.ToString();
            cardTotalRevenue.CardDescription = $"from {_content.VehicleTotal} vehicle";
            cardAvailableSpace.CardValue = _content.CurrentVehicle.ToString();
            cardAvailableSpace.CardDescription = $"with availabe space {_content.AvailableSpace} vehicle";
            cardExitGateway.CardValue = _content.ExitRevenue.ToString();
            cardExitGateway.CardDescription = $"from {_content.ExitTotal} vehicle";
            cardFineReport.CardValue = _content.FineRevenue.ToString();
            cardFineReport.CardDescription = $"from {_content.FineTotal} vehicle";
        }

        private void onTimeFramChange(object sender, EventArgs e)
        {
            _timeFrequency = cmbTimeFrequency.Text;
            UpdateData();
        }
    }
}
