namespace ParkEase.View
{
    partial class frmChangePassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ucTopBar = new UserControls.UC_TopBar();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblLogo = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            txtPasswordConfirmation = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).BeginInit();
            SuspendLayout();
            // 
            // ucTopBar
            // 
            ucTopBar.Dock = DockStyle.Top;
            ucTopBar.Location = new Point(0, 0);
            ucTopBar.Name = "ucTopBar";
            ucTopBar.Size = new Size(1086, 56);
            ucTopBar.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.FromArgb(255, 254, 234);
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.picture_changepassword;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(546, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(536, 672);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 8;
            guna2Elipse2.TargetControl = btnChangePassword;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.CustomizableEdges = customizableEdges3;
            btnChangePassword.DisabledState.BorderColor = Color.DarkGray;
            btnChangePassword.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChangePassword.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChangePassword.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChangePassword.FillColor = Color.FromArgb(226, 139, 0);
            btnChangePassword.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(63, 610);
            btnChangePassword.Margin = new Padding(0);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnChangePassword.Size = new Size(411, 61);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.TextOffset = new Point(0, -2);
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(guna2PictureBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1086, 771);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblLogo, 0, 1);
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 2);
            tableLayoutPanel2.Controls.Add(lblDescription, 0, 3);
            tableLayoutPanel2.Controls.Add(btnChangePassword, 0, 8);
            tableLayoutPanel2.Controls.Add(txtPasswordConfirmation, 0, 7);
            tableLayoutPanel2.Controls.Add(txtPassword, 0, 6);
            tableLayoutPanel2.Controls.Add(txtOldPassword, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(537, 763);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.BackColor = Color.FromArgb(255, 254, 234);
            lblLogo.Cursor = Cursors.Hand;
            lblLogo.Image = Properties.Resources.logo_park_ease_oranye;
            lblLogo.Location = new Point(178, 100);
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
            lblTitle.Location = new Point(58, 203);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(421, 52);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "CHANGE PASSWORD";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(47, 283);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(442, 38);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Revamp your account's security effortlessly and regain control \r\nwith our user-friendly and secure password change feature.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPasswordConfirmation
            // 
            txtPasswordConfirmation.Anchor = AnchorStyles.None;
            txtPasswordConfirmation.Animated = true;
            txtPasswordConfirmation.BackColor = Color.Transparent;
            txtPasswordConfirmation.BorderColor = Color.FromArgb(255, 244, 133);
            txtPasswordConfirmation.BorderRadius = 8;
            txtPasswordConfirmation.BorderThickness = 2;
            txtPasswordConfirmation.CustomizableEdges = customizableEdges5;
            txtPasswordConfirmation.DefaultText = "";
            txtPasswordConfirmation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPasswordConfirmation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPasswordConfirmation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPasswordConfirmation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPasswordConfirmation.FillColor = Color.FromArgb(255, 249, 197);
            txtPasswordConfirmation.FocusedState.BorderColor = Color.Transparent;
            txtPasswordConfirmation.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtPasswordConfirmation.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordConfirmation.ForeColor = Color.FromArgb(226, 139, 0);
            txtPasswordConfirmation.HoverState.BorderColor = Color.Transparent;
            txtPasswordConfirmation.IconLeft = Properties.Resources.icon_key;
            txtPasswordConfirmation.IconLeftOffset = new Point(10, 0);
            txtPasswordConfirmation.IconRightOffset = new Point(10, 0);
            txtPasswordConfirmation.Location = new Point(63, 526);
            txtPasswordConfirmation.Margin = new Padding(0);
            txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            txtPasswordConfirmation.PasswordChar = '*';
            txtPasswordConfirmation.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtPasswordConfirmation.PlaceholderText = "New Password Confirmation";
            txtPasswordConfirmation.SelectedText = "";
            txtPasswordConfirmation.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPasswordConfirmation.Size = new Size(411, 61);
            txtPasswordConfirmation.TabIndex = 3;
            txtPasswordConfirmation.TextOffset = new Point(10, -2);
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Animated = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderColor = Color.FromArgb(255, 244, 133);
            txtPassword.BorderRadius = 8;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(255, 249, 197);
            txtPassword.FocusedState.BorderColor = Color.Transparent;
            txtPassword.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtPassword.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(226, 139, 0);
            txtPassword.HoverState.BorderColor = Color.Transparent;
            txtPassword.IconLeft = Properties.Resources.icon_key;
            txtPassword.IconLeftOffset = new Point(10, 0);
            txtPassword.IconRightOffset = new Point(10, 0);
            txtPassword.Location = new Point(63, 451);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtPassword.PlaceholderText = "New Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(411, 61);
            txtPassword.TabIndex = 2;
            txtPassword.TextOffset = new Point(10, -2);
            // 
            // txtOldPassword
            // 
            txtOldPassword.Anchor = AnchorStyles.None;
            txtOldPassword.Animated = true;
            txtOldPassword.BackColor = Color.Transparent;
            txtOldPassword.BorderColor = Color.FromArgb(255, 244, 133);
            txtOldPassword.BorderRadius = 8;
            txtOldPassword.BorderThickness = 2;
            txtOldPassword.CustomizableEdges = customizableEdges9;
            txtOldPassword.DefaultText = "";
            txtOldPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOldPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOldPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOldPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOldPassword.FillColor = Color.FromArgb(255, 249, 197);
            txtOldPassword.FocusedState.BorderColor = Color.Transparent;
            txtOldPassword.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtOldPassword.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassword.ForeColor = Color.FromArgb(226, 139, 0);
            txtOldPassword.HoverState.BorderColor = Color.Transparent;
            txtOldPassword.IconLeft = Properties.Resources.icon_key;
            txtOldPassword.IconLeftOffset = new Point(10, 0);
            txtOldPassword.IconRightOffset = new Point(10, 0);
            txtOldPassword.Location = new Point(63, 376);
            txtOldPassword.Margin = new Padding(0);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtOldPassword.PlaceholderText = "Old Password";
            txtOldPassword.SelectedText = "";
            txtOldPassword.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtOldPassword.Size = new Size(411, 61);
            txtOldPassword.TabIndex = 1;
            txtOldPassword.TextOffset = new Point(10, -2);
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockForm = true;
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = tableLayoutPanel2;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(1086, 827);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ucTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChangePassword";
            Text = "Change_Password";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UC_TopBar ucTopBar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox lblLogo;
        private Label lblTitle;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordConfirmation;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}