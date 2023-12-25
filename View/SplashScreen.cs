using System;

namespace ParkEase.View
{
    public partial class SplashScreen : Form
    {
        private List<string> informations = new List<string>();

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
                "Completing final touches ...",
                "Welcome to Park Ease!"
            };

            labelLoadingInformation.Text = this.informations[0];
            Thread thread = new Thread(new ThreadStart(this.ShowLoadingInformation));
            thread.Start();
        }

        private void ShowLoadingInformation()
        {
            Random random = new Random();

            for (int idx = 0; idx < this.informations.Count; idx++)
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelLoadingInformation.Text = this.informations[idx];
                    });
                }

                Thread.Sleep(random.Next(100, 600));
            }

            this.SplashScreenFinished();
        }

        private void SplashScreenFinished()
        {
            Application.Exit();
            Application.Run(new frmLogin());
        }
    }
}
