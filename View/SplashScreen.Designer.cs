namespace ParkEase.View
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imgIllustrator = new PictureBox();
            imgLogo = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblPark = new Label();
            lblDescription = new Label();
            imgLogoBottom = new PictureBox();
            lblEaseCompany = new Label();
            lblCopyright = new Label();
            lblLoadingInformation = new Label();
            ((System.ComponentModel.ISupportInitialize)imgIllustrator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoBottom).BeginInit();
            SuspendLayout();
            // 
            // imgIllustrator
            // 
            imgIllustrator.Image = Properties.Resources.Parking_amico;
            imgIllustrator.Location = new Point(365, 37);
            imgIllustrator.Margin = new Padding(3, 2, 3, 2);
            imgIllustrator.Name = "imgIllustrator";
            imgIllustrator.Size = new Size(563, 451);
            imgIllustrator.SizeMode = PictureBoxSizeMode.StretchImage;
            imgIllustrator.TabIndex = 0;
            imgIllustrator.TabStop = false;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.FromArgb(255, 254, 234);
            imgLogo.Cursor = Cursors.Hand;
            imgLogo.Image = Properties.Resources.logo_park_ease_oranye;
            imgLogo.Location = new Point(31, 37);
            imgLogo.Margin = new Padding(3, 2, 3, 2);
            imgLogo.Name = "imgLogo";
            imgLogo.Padding = new Padding(9, 8, 9, 8);
            imgLogo.Size = new Size(175, 48);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 3;
            imgLogo.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // lblPark
            // 
            lblPark.AutoSize = true;
            lblPark.BackColor = Color.FromArgb(255, 254, 234);
            lblPark.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPark.ForeColor = SystemColors.ControlDarkDark;
            lblPark.Location = new Point(74, 472);
            lblPark.Name = "lblPark";
            lblPark.Size = new Size(36, 18);
            lblPark.TabIndex = 4;
            lblPark.Text = "ARK";
            lblPark.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(31, 145);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(276, 32);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Park Ease ensures that every element, including text, \r\nimages and designs, is our exclusive property. ";
            // 
            // imgLogoBottom
            // 
            imgLogoBottom.BackColor = Color.FromArgb(255, 254, 234);
            imgLogoBottom.Cursor = Cursors.Hand;
            imgLogoBottom.Image = Properties.Resources.icon_parking_active;
            imgLogoBottom.Location = new Point(31, 450);
            imgLogoBottom.Margin = new Padding(3, 2, 3, 2);
            imgLogoBottom.Name = "imgLogoBottom";
            imgLogoBottom.Padding = new Padding(9, 8, 9, 8);
            imgLogoBottom.Size = new Size(52, 50);
            imgLogoBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogoBottom.TabIndex = 3;
            imgLogoBottom.TabStop = false;
            // 
            // lblEaseCompany
            // 
            lblEaseCompany.AutoSize = true;
            lblEaseCompany.BackColor = Color.FromArgb(255, 254, 234);
            lblEaseCompany.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEaseCompany.ForeColor = Color.FromArgb(226, 139, 0);
            lblEaseCompany.Location = new Point(109, 472);
            lblEaseCompany.Name = "lblEaseCompany";
            lblEaseCompany.Size = new Size(112, 18);
            lblEaseCompany.TabIndex = 4;
            lblEaseCompany.Text = "EASE COMPANY";
            lblEaseCompany.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.FromArgb(255, 254, 234);
            lblCopyright.Font = new Font("Ubuntu", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.ForeColor = SystemColors.ControlDarkDark;
            lblCopyright.Location = new Point(31, 109);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(227, 16);
            lblCopyright.TabIndex = 4;
            lblCopyright.Text = "© 2023 - Now ParkEase. All right reserved.";
            // 
            // lblLoadingInformation
            // 
            lblLoadingInformation.AutoSize = true;
            lblLoadingInformation.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoadingInformation.ForeColor = SystemColors.ControlDarkDark;
            lblLoadingInformation.Location = new Point(31, 192);
            lblLoadingInformation.Name = "lblLoadingInformation";
            lblLoadingInformation.Size = new Size(145, 16);
            lblLoadingInformation.TabIndex = 5;
            lblLoadingInformation.Text = "Preparing the application ...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(938, 531);
            Controls.Add(lblLoadingInformation);
            Controls.Add(lblCopyright);
            Controls.Add(lblDescription);
            Controls.Add(lblEaseCompany);
            Controls.Add(lblPark);
            Controls.Add(imgLogoBottom);
            Controls.Add(imgLogo);
            Controls.Add(imgIllustrator);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += formOnLoad;
            ((System.ComponentModel.ISupportInitialize)imgIllustrator).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgIllustrator;
        private PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label lblPark;
        private Label lblDescription;
        private PictureBox imgLogoBottom;
        private Label lblEaseCompany;
        private Label lblCopyright;
        private Label lblLoadingInformation;
    }
}