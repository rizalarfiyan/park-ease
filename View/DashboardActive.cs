using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using Guna.Charts.WinForms;
using Guna.Charts.Interfaces;

namespace ParkEase.View
{
    public partial class DashboardActive : Form
    {
        public DashboardActive()
        {
            InitializeComponent();
        }

        private void chartDashboard_Load(object sender, EventArgs e)
        {
            string[] topic = { "Total Revenue", "Subscriptions", "Sales", "Active" };

            lineDataset_1.PointRadius = 5;
            lineDataset_1.PointStyle = PointStyle.Circle;

            lineDataset_2.PointRadius = 5;
            lineDataset_2.PointStyle = PointStyle.Circle;

            var r = new Random();
            for (int i = 0; i < topic.Length; i++)
            {
                int num = r.Next(10, 100);

                lineDataset_1.DataPoints.Add(topic[i], num);
            }

            for (int i = 0; i < topic.Length; i++)
            {
                int num = r.Next(10, 100);


                lineDataset_2.DataPoints.Add(topic[i], num);
            }

            chartDashboard.Datasets.Add(lineDataset_1);
            chartDashboard.Datasets.Add(lineDataset_2);

            chartDashboard.Update();
        }
    }
}
