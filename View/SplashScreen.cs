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
            this.informations = new List<string>()
            {
                "Preparing the application ...",
                "Optimizing performance ...",
                "Establishing secure connection ...",
                "Loading essential resources ...",
                "Completing final touches ..."
            };

            labelLoadingInformation.Text = this.informations[0];
            Thread thread = new Thread(new ThreadStart(this.ShowLoadingInformation));
            thread.Start();

            authMeTask = Task.Run(async () =>
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
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                }
            });
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

        private void ShowLoadingInformation()
        {
            Random random = new Random();

            for (int idx = 0; idx < this.informations.Count; idx++)
            {
                SetLoadingInformation(this.informations[idx]);
                Thread.Sleep(random.Next(300, 1200));
            }

            if (authMeTask != null && !authMeTask.IsCompleted)
            {
                authMeTask.Wait();
            }

            if (isFinished)
            {
                SetLoadingInformation("Welcome to Park Ease!");
                Thread.Sleep(random.Next(300, 1200));

                this.SplashScreenFinished();
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
