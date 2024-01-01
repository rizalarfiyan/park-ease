namespace ParkEase.View
{
    partial class frmLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblIllustrator = new Guna.UI2.WinForms.Guna2PictureBox();
            elipseForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            tblWrapper = new TableLayoutPanel();
            tblContent = new TableLayoutPanel();
            lblLogo = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ucTopBar = new UserControls.UC_TopBar();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)lblIllustrator).BeginInit();
            tblWrapper.SuspendLayout();
            tblContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).BeginInit();
            SuspendLayout();
            // 
            // lblIllustrator
            // 
            lblIllustrator.BackColor = Color.FromArgb(255, 254, 234);
            lblIllustrator.CustomizableEdges = customizableEdges1;
            lblIllustrator.Dock = DockStyle.Fill;
            lblIllustrator.Image = Properties.Resources.parking_picture_login;
            lblIllustrator.ImageRotate = 0F;
            lblIllustrator.Location = new Point(3, 3);
            lblIllustrator.Name = "lblIllustrator";
            lblIllustrator.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lblIllustrator.Size = new Size(530, 646);
            lblIllustrator.SizeMode = PictureBoxSizeMode.StretchImage;
            lblIllustrator.TabIndex = 3;
            lblIllustrator.TabStop = false;
            // 
            // elipseForm
            // 
            elipseForm.BorderRadius = 25;
            elipseForm.TargetControl = this;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BorderRadius = 8;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(226, 139, 0);
            btnLogin.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(59, 500);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(411, 61);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextOffset = new Point(0, -2);
            btnLogin.Click += btnLogin_Click;
            // 
            // tblWrapper
            // 
            tblWrapper.ColumnCount = 2;
            tblWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblWrapper.Controls.Add(tblContent, 0, 0);
            tblWrapper.Controls.Add(lblIllustrator, 0, 0);
            tblWrapper.Dock = DockStyle.Fill;
            tblWrapper.Location = new Point(0, 56);
            tblWrapper.Margin = new Padding(3, 4, 3, 4);
            tblWrapper.Name = "tblWrapper";
            tblWrapper.RowCount = 1;
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblWrapper.Size = new Size(1072, 652);
            tblWrapper.TabIndex = 5;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(lblLogo, 0, 1);
            tblContent.Controls.Add(lblTitle, 0, 2);
            tblContent.Controls.Add(lblDescription, 0, 3);
            tblContent.Controls.Add(btnLogin, 0, 7);
            tblContent.Controls.Add(txtUsername, 0, 5);
            tblContent.Controls.Add(txtPassword, 0, 6);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(539, 4);
            tblContent.Margin = new Padding(3, 4, 3, 4);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 9;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.Size = new Size(530, 644);
            tblContent.TabIndex = 13;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.BackColor = Color.FromArgb(255, 254, 234);
            lblLogo.Cursor = Cursors.Hand;
            lblLogo.Image = Properties.Resources.logo_park_ease_oranye;
            lblLogo.Location = new Point(174, 91);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(10, 11, 10, 11);
            lblLogo.Size = new Size(181, 59);
            lblLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            lblLogo.TabIndex = 7;
            lblLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(192, 181);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 52);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "LOGIN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(15, 248);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(499, 38);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Easily simplify your parking operations – log in and optimize your parking solutions.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Animated = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderColor = Color.FromArgb(255, 231, 70);
            txtUsername.BorderRadius = 8;
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges5;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(255, 249, 197);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtUsername.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(187, 98, 2);
            txtUsername.HoverState.BorderColor = Color.Transparent;
            txtUsername.IconLeft = Properties.Resources.icon_users_active;
            txtUsername.IconLeftOffset = new Point(10, 0);
            txtUsername.IconRightOffset = new Point(10, 0);
            txtUsername.Location = new Point(59, 341);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtUsername.Size = new Size(411, 61);
            txtUsername.TabIndex = 9;
            txtUsername.TextOffset = new Point(10, -2);
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Animated = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderColor = Color.FromArgb(255, 231, 70);
            txtPassword.BorderRadius = 8;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(255, 249, 197);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtPassword.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(187, 98, 2);
            txtPassword.HoverState.BorderColor = Color.Transparent;
            txtPassword.IconLeft = Properties.Resources.icon_key;
            txtPassword.IconLeftOffset = new Point(10, 0);
            txtPassword.IconRightOffset = new Point(10, 0);
            txtPassword.Location = new Point(59, 416);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(411, 61);
            txtPassword.TabIndex = 9;
            txtPassword.TextOffset = new Point(10, -2);
            // 
            // ucTopBar
            // 
            ucTopBar.Dock = DockStyle.Top;
            ucTopBar.Location = new Point(0, 0);
            ucTopBar.Name = "ucTopBar";
            ucTopBar.Size = new Size(1072, 56);
            ucTopBar.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockForm = true;
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = tblContent;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(1072, 708);
            Controls.Add(tblWrapper);
            Controls.Add(ucTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)lblIllustrator).EndInit();
            tblWrapper.ResumeLayout(false);
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox lblIllustrator;
        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private TableLayoutPanel tblWrapper;
        private UserControls.UC_TopBar ucTopBar;
        private TableLayoutPanel tblContent;
        private PictureBox lblLogo;
        private Label lblTitle;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}