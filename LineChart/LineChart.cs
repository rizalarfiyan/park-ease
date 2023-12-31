using Guna.Charts.WinForms;

namespace ParkEase.LineChart
{
    class LineChart
    {
        public static void LineCart(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] topic = { "Total Revenue", "Subscriptions", "Sales", "Active" };

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < topic.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(topic[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
