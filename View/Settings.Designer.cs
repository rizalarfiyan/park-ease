namespace ParkEase.View
{
    partial class Settings
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblLogo = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            lblLostTicket = new Label();
            txtLostTicket = new Guna.UI2.WinForms.Guna2TextBox();
            lblNextHour = new Label();
            txtNextHour = new Guna.UI2.WinForms.Guna2TextBox();
            btnCencel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tableLayoutPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(guna2Panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(guna2Panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 422F));
            tableLayoutPanel1.Size = new Size(794, 627);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnCencel);
            guna2Panel1.Controls.Add(btnSave);
            guna2Panel1.Controls.Add(txtNextHour);
            guna2Panel1.Controls.Add(lblNextHour);
            guna2Panel1.Controls.Add(txtLostTicket);
            guna2Panel1.Controls.Add(lblLostTicket);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(3, 208);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(788, 373);
            guna2Panel1.TabIndex = 9;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(lblDescription);
            guna2Panel2.Controls.Add(lblTitle);
            guna2Panel2.Controls.Add(lblLogo);
            guna2Panel2.CustomizableEdges = customizableEdges11;
            guna2Panel2.Location = new Point(3, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel2.Size = new Size(788, 199);
            guna2Panel2.TabIndex = 10;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.BackColor = Color.White;
            lblLogo.Cursor = Cursors.Hand;
            lblLogo.Image = Properties.Resources.logo_park_ease_oranye;
            lblLogo.Location = new Point(536, 55);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(10, 11, 10, 11);
            lblLogo.Size = new Size(181, 59);
            lblLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            lblLogo.TabIndex = 8;
            lblLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(28, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 52);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "SETTINGS";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(28, 129);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(370, 38);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Easily simplify your parking operations – settings and \r\noptimize your parking solutions.";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLostTicket
            // 
            lblLostTicket.Anchor = AnchorStyles.None;
            lblLostTicket.AutoSize = true;
            lblLostTicket.BackColor = Color.White;
            lblLostTicket.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLostTicket.ForeColor = Color.FromArgb(226, 139, 0);
            lblLostTicket.Location = new Point(28, 54);
            lblLostTicket.Name = "lblLostTicket";
            lblLostTicket.Size = new Size(117, 26);
            lblLostTicket.TabIndex = 10;
            lblLostTicket.Text = "Lost Ticket";
            lblLostTicket.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLostTicket
            // 
            txtLostTicket.Anchor = AnchorStyles.None;
            txtLostTicket.Animated = true;
            txtLostTicket.BackColor = Color.Transparent;
            txtLostTicket.BorderColor = Color.FromArgb(255, 244, 133);
            txtLostTicket.BorderRadius = 8;
            txtLostTicket.BorderThickness = 2;
            txtLostTicket.CustomizableEdges = customizableEdges7;
            txtLostTicket.DefaultText = "";
            txtLostTicket.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLostTicket.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLostTicket.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLostTicket.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLostTicket.FillColor = Color.FromArgb(255, 249, 197);
            txtLostTicket.FocusedState.BorderColor = Color.Transparent;
            txtLostTicket.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtLostTicket.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLostTicket.ForeColor = Color.FromArgb(226, 139, 0);
            txtLostTicket.HoverState.BorderColor = Color.Transparent;
            txtLostTicket.IconLeftOffset = new Point(10, 0);
            txtLostTicket.IconRightOffset = new Point(10, 0);
            txtLostTicket.Location = new Point(184, 42);
            txtLostTicket.Margin = new Padding(0);
            txtLostTicket.Name = "txtLostTicket";
            txtLostTicket.PasswordChar = '\0';
            txtLostTicket.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtLostTicket.PlaceholderText = "";
            txtLostTicket.SelectedText = "";
            txtLostTicket.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtLostTicket.Size = new Size(464, 51);
            txtLostTicket.TabIndex = 11;
            txtLostTicket.TextOffset = new Point(10, -2);
            // 
            // lblNextHour
            // 
            lblNextHour.Anchor = AnchorStyles.None;
            lblNextHour.AutoSize = true;
            lblNextHour.BackColor = Color.White;
            lblNextHour.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNextHour.ForeColor = Color.FromArgb(226, 139, 0);
            lblNextHour.Location = new Point(28, 150);
            lblNextHour.Name = "lblNextHour";
            lblNextHour.Size = new Size(111, 26);
            lblNextHour.TabIndex = 10;
            lblNextHour.Text = "Next Hour";
            lblNextHour.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNextHour
            // 
            txtNextHour.Anchor = AnchorStyles.None;
            txtNextHour.Animated = true;
            txtNextHour.BackColor = Color.Transparent;
            txtNextHour.BorderColor = Color.FromArgb(255, 244, 133);
            txtNextHour.BorderRadius = 8;
            txtNextHour.BorderThickness = 2;
            txtNextHour.CustomizableEdges = customizableEdges5;
            txtNextHour.DefaultText = "";
            txtNextHour.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNextHour.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNextHour.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNextHour.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNextHour.FillColor = Color.FromArgb(255, 249, 197);
            txtNextHour.FocusedState.BorderColor = Color.Transparent;
            txtNextHour.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtNextHour.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNextHour.ForeColor = Color.FromArgb(226, 139, 0);
            txtNextHour.HoverState.BorderColor = Color.Transparent;
            txtNextHour.IconLeftOffset = new Point(10, 0);
            txtNextHour.IconRightOffset = new Point(10, 0);
            txtNextHour.Location = new Point(184, 138);
            txtNextHour.Margin = new Padding(0);
            txtNextHour.Name = "txtNextHour";
            txtNextHour.PasswordChar = '\0';
            txtNextHour.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtNextHour.PlaceholderText = "";
            txtNextHour.SelectedText = "";
            txtNextHour.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNextHour.Size = new Size(464, 51);
            txtNextHour.TabIndex = 11;
            txtNextHour.TextOffset = new Point(10, -2);
            // 
            // btnCencel
            // 
            btnCencel.Cursor = Cursors.Hand;
            btnCencel.CustomizableEdges = customizableEdges1;
            btnCencel.DisabledState.BorderColor = Color.DarkGray;
            btnCencel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCencel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCencel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCencel.FillColor = Color.FromArgb(255, 231, 70);
            btnCencel.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCencel.ForeColor = Color.White;
            btnCencel.Location = new Point(184, 266);
            btnCencel.Margin = new Padding(0);
            btnCencel.Name = "btnCencel";
            btnCencel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCencel.Size = new Size(214, 69);
            btnCencel.TabIndex = 14;
            btnCencel.Text = "Cancel";
            btnCencel.TextOffset = new Point(0, -2);
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(226, 139, 0);
            btnSave.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(443, 266);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(205, 69);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.TextOffset = new Point(0, -2);
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 8;
            guna2Elipse1.TargetControl = btnCencel;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 8;
            guna2Elipse2.TargetControl = btnSave;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 627);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            tableLayoutPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private PictureBox lblLogo;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblLostTicket;
        private Guna.UI2.WinForms.Guna2TextBox txtNextHour;
        private Label lblNextHour;
        private Guna.UI2.WinForms.Guna2TextBox txtLostTicket;
        private Guna.UI2.WinForms.Guna2Button btnCencel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}