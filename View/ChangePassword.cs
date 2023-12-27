namespace ParkEase.View
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            ucTopBar.SetForm(this);
        }
    }
}
