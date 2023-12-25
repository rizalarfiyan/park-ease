using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ParkEase.View
{
    public partial class SplashScreen : Form
    {
        private bool isClosing = false;

        public SplashScreen()
        {
            InitializeComponent();
            // Set the label text
            labelLoadingInformation.Text = "Preparing the application ...";

            // Create a new thread to rotate the text
            Thread thread = new Thread(new ThreadStart(this.RotateText));
            thread.Start();
        }

        private void RotateText()
        {
            // Create a list of text to rotate
            List<string> texts = new List<string>()
            {
                "Preparing the application ...",
                "Optimizing performance ...",
                "Establishing secure connection ...",
                "Loading essential resources ...",
                "Completing final touches ...",
                "Welcome to Park Ease!"
            };

            // Create a random object outside the loop
            Random random = new Random();

            // Loop through the list and rotate the text
            while (!isClosing)
            {
                // Get a random text from the list
                int index = random.Next(texts.Count);
                string text = texts[index];

                // Check if the form handle has been created
                if (this.IsHandleCreated)
                {
                    // Set the label text using Invoke to update UI from another thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelLoadingInformation.Text = text;
                    });

                    if (labelLoadingInformation.Text == "Welcome to Park Ease!")
                    {
                        Application.Run(new frmLogin());
                    }
                }

                // Sleep for a random amount of time
                Thread.Sleep(random.Next(1000, 5000));
            }
        }

    }
}
