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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Parking_amico;
            pictureBox1.Location = new Point(417, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 254, 234);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.logo_park_ease_oranye;
            pictureBox2.Location = new Point(35, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10, 11, 10, 11);
            pictureBox2.Size = new Size(200, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 254, 234);
            label2.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(85, 629);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 4;
            label2.Text = "ARK";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 254, 234);
            label1.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(35, 193);
            label1.Name = "label1";
            label1.Size = new Size(345, 36);
            label1.TabIndex = 4;
            label1.Text = "Park Ease ensures that every element, including text, \r\nimages and designs, is our exclusive property. ";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(255, 254, 234);
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.icon_parking_active;
            pictureBox4.Location = new Point(35, 607);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(10, 11, 10, 11);
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 254, 234);
            label3.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(226, 139, 0);
            label3.Location = new Point(125, 629);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 4;
            label3.Text = "EASE COMPANY";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 254, 234);
            label4.Font = new Font("Ubuntu", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(35, 145);
            label4.Name = "label4";
            label4.Size = new Size(280, 17);
            label4.TabIndex = 4;
            label4.Text = "© 2023 - Now ParkEase. All right reserved.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(35, 256);
            label5.Name = "label5";
            label5.Size = new Size(178, 18);
            label5.TabIndex = 5;
            label5.Text = "Preparing the application ...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(1072, 708);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}