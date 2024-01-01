using ParkEase.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase.View
{
    public partial class ExitTicket : Form
    {
        public ExitTicket()
        {
            InitializeComponent();
            dragControl.TargetControl = ucTopBar.GetPanel();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
