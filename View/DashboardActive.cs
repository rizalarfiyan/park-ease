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
            LineChart.LineChart.LineCart(chartDashboard);
        }
    }
}
