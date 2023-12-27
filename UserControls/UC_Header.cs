namespace ParkEase.UserControls
{
    public partial class UC_Header : UserControl
    {
        public UC_Header()
        {
            InitializeComponent();
        }

        public void SetUsername(string username)
        {
            lblUsername.Text = username;
        }

        public void SetRole(string role)
        {
            lblRole.Text = role;
        }

        public void SetAvatar(string fullName)
        {
            fullName = fullName.Trim();
            if (string.IsNullOrEmpty(fullName))
            {
                lblAvatar.Text = "AA";
                return;
            }

            string[] nameParts = fullName.Split(' ');
            if (nameParts.Length >= 2 && nameParts[0].Length >= 1 && nameParts[0].Length >= 1) {
                lblAvatar.Text = (nameParts[0].Substring(0, 1) + nameParts[1].Substring(0, 1)).ToUpper();
                return;
            }

            lblAvatar.Text = fullName.Substring(2).ToUpper();
        }
    }
}
