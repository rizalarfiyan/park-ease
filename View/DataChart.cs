using Guna.Charts.WinForms;

namespace ParkEase.View
{
    public partial class DataChart : Form
    {
        private GunaChart chart;
        public DataChart()
        {
            InitializeComponent();

            this.chart = new GunaChart();

            this.Controls.Add(this.chart);

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            var r = new Random();
            dataset.DataPoints.Add("Total Revenue", r.Next(-50, 100));
            dataset.DataPoints.Add("Subscriptions", r.Next(-50, 100));
            dataset.DataPoints.Add("Sales", r.Next(-50, 100));
            dataset.DataPoints.Add("Active", r.Next(-50, 100));

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
