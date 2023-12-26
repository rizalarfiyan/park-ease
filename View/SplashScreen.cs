using ParkEase.Model.Repository;

namespace ParkEase.View
{
    public partial class SplashScreen : Form
    {
        private List<string> informations = new List<string>();

        private bool isLoggedIn = false;

        private bool isFinished = false;

        private string errorMessage = "Could't connect to server, please try again later!";

        private Task? authMeTask = null;

        public SplashScreen()
        {
            InitializeComponent();
            InitializeLoadingInformation();
        }

        private void InitializeLoadingInformation()
        {
            informations = new List<string>()
            {
                "Preparing the application ...",
                "Optimizing performance ...",
                "Establishing secure connection ...",
                "Loading essential resources ...",
                "Completing final touches ...",
                "Getting User info ...",
            };

            labelLoadingInformation.Text = informations[0];
            Thread thread = new Thread(new ThreadStart(ShowLoadingInformation));
            thread.Start();

            authMeTask = Task.Run(async () => await AuthenticateAsync());
        }

        private void SetLoadingInformation(string message)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    labelLoadingInformation.Text = message;
                });
            }
        }

        async Task AuthenticateAsync()
        {
            try
            {
                var data = await new AuthRepository().Me();
                if (data == null)
                {
                    return;
                }

                if (data.Data != null)
                {
                    Program.UserData = data.Data;
                    isLoggedIn = true;
                }

                isFinished = true;
                System.Diagnostics.Debug.Print("Authentication successful!");
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                System.Diagnostics.Debug.Print($"Error during authentication: {ex.Message}");
            }
        }

        private void ShowLoadingInformation()
        {
            Random random = new Random();

            for (int idx = 0; idx < informations.Count; idx++)
            {
                SetLoadingInformation(informations[idx]);
                Thread.Sleep(random.Next(800, 2500));
            }

            if (authMeTask != null && !authMeTask.IsCompleted)
            {
                authMeTask.Wait();
            }

            if (isFinished)
            {
                SetLoadingInformation("Welcome to Park Ease!");
                Thread.Sleep(random.Next(300, 1200));

                SplashScreenFinished();
                return;
            }

            DialogResult dialog = MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void SplashScreenFinished()
        {
            Application.Exit();
            if (isLoggedIn)
            {
                Application.Run(new frmHome());
                return;
            }
            Application.Run(new frmLogin());
        }
    }
}
