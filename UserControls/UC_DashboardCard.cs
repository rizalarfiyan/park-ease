using System.ComponentModel;

namespace ParkEase.UserControls
{
    public partial class UCDashboardCard : UserControl
    {
        public UCDashboardCard()
        {
            InitializeComponent();
        }

        [DefaultValue("Total Revenue")]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Set the title of card")]
        public string CardTitle
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        [DefaultValue("Rp50.000")]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Set the value of card")]
        public string CardValue
        {
            get
            {
                return lblValue.Text;
            }
            set
            {
                lblValue.Text = value;
            }
        }

        [DefaultValue("+23% from last month")]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Set the value of card")]
        public string CardDescription
        {
            get
            {
                return lblDescription.Text;
            }
            set
            {
                lblDescription.Text = value;
            }
        }

        //[DefaultValue("+23% from last month")]
        [Category("Appearance")]
        [Browsable(true)]
        [Description("Set the icon of card")]
        public Image CardIcon
        {
            get
            {
                return imgIcon.Image;
            }
            set
            {
                imgIcon.Image = value;
            }
        }
    }
}
