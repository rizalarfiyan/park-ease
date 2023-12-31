﻿using Guna.Charts.WinForms;
using ParkEase.Constants;
using ParkEase.Controller;
using ParkEase.Model.Entity;
using ParkEase.Utils;

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
            cardTotalRevenue.CardValue = Format.FormatCurrencyIDR(_content.RevenueTotal);
            cardTotalRevenue.CardDescription = $"from {_content.ExitTotal + _content.FineTotal} vehicle";
            cardAvailableSpace.CardValue = _content.AvailableSpace.ToString();
            cardAvailableSpace.CardDescription = $"from {_content.CurrentVehicle} vehicle";
            cardExitGateway.CardValue = Format.FormatCurrencyIDR(_content.ExitRevenue);
            cardExitGateway.CardDescription = $"from {_content.ExitTotal} vehicle";
            cardFineReport.CardValue = Format.FormatCurrencyIDR(_content.FineRevenue);
            cardFineReport.CardDescription = $"from {_content.FineTotal} vehicle";
        }

        private void onTimeFramChange(object sender, EventArgs e)
        {
            _timeFrequency = App.LIST_TIME_FREQUENCY_VALUE[cmbTimeFrequency.SelectedIndex];
            UpdateData();
        }
    }
}
