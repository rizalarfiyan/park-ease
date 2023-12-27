namespace ParkEase.UserControls
{
    partial class UC_Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUsername = new Label();
            lblRole = new Label();
            btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            lblAvatar = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(308, 1);
            lblUsername.Margin = new Padding(0, 0, 0, 1);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(57, 21);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Admin";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.FromArgb(226, 139, 0);
            lblRole.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(327, 24);
            lblRole.Margin = new Padding(0, 1, 5, 0);
            lblRole.Name = "lblRole";
            lblRole.Padding = new Padding(2, 1, 2, 1);
            lblRole.RightToLeft = RightToLeft.Yes;
            lblRole.Size = new Size(33, 18);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.CustomizableEdges = customizableEdges1;
            btnChangePassword.DisabledState.BorderColor = Color.Transparent;
            btnChangePassword.DisabledState.CustomBorderColor = Color.Transparent;
            btnChangePassword.DisabledState.FillColor = Color.Transparent;
            btnChangePassword.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChangePassword.FillColor = Color.Transparent;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.HoverState.CustomBorderColor = Color.Transparent;
            btnChangePassword.HoverState.FillColor = Color.Transparent;
            btnChangePassword.HoverState.Image = Properties.Resources.icon_key;
            btnChangePassword.Image = Properties.Resources.icon_key;
            btnChangePassword.ImageSize = new Size(25, 25);
            btnChangePassword.Location = new Point(677, 11);
            btnChangePassword.Margin = new Padding(3, 2, 3, 2);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnChangePassword.Size = new Size(35, 30);
            btnChangePassword.TabIndex = 13;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblAvatar
            // 
            lblAvatar.Anchor = AnchorStyles.None;
            lblAvatar.AutoSize = true;
            lblAvatar.BackColor = Color.FromArgb(226, 139, 0);
            lblAvatar.Font = new Font("Ubuntu", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(608, 5);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Padding = new Padding(3, 8, 3, 8);
            lblAvatar.Size = new Size(49, 42);
            lblAvatar.TabIndex = 14;
            lblAvatar.Text = "AA";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3720932F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6279068F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnChangePassword, 3, 0);
            tableLayoutPanel1.Controls.Add(lblAvatar, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(727, 53);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblRole, 0, 1);
            tableLayoutPanel2.Controls.Add(lblUsername, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(234, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(365, 47);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 8;
            guna2Elipse2.TargetControl = lblAvatar;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = lblRole;
            // 
            // UC_Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Header";
            Size = new Size(727, 53);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUsername;
        private Label lblRole;
        public Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Label lblAvatar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
