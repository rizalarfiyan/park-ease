namespace ParkEase.View
{
    partial class FormVehicleType
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            elipseForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            ucTopBar = new UserControls.UC_TopBar();
            tblParent = new TableLayoutPanel();
            tblContent = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            tblButtonAction = new TableLayoutPanel();
            tbnFormContent = new TableLayoutPanel();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            lblCode = new Label();
            lblName = new Label();
            lblPrice = new Label();
            picIllustrator = new Guna.UI2.WinForms.Guna2PictureBox();
            tblParent.SuspendLayout();
            tblContent.SuspendLayout();
            tblButtonAction.SuspendLayout();
            tbnFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIllustrator).BeginInit();
            SuspendLayout();
            // 
            // elipseForm
            // 
            elipseForm.BorderRadius = 25;
            elipseForm.TargetControl = this;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(255, 254, 234);
            btnCancel.BorderRadius = 8;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(255, 254, 234);
            btnCancel.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(124, 62, 11);
            btnCancel.HoverState.FillColor = Color.FromArgb(255, 249, 197);
            btnCancel.Location = new Point(50, 9);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.TextOffset = new Point(0, -2);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.BorderColor = Color.FromArgb(226, 139, 0);
            btnSave.BorderRadius = 8;
            btnSave.BorderThickness = 2;
            btnSave.CheckedState.FillColor = Color.FromArgb(187, 98, 2);
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(226, 139, 0);
            btnSave.FocusedColor = Color.FromArgb(187, 98, 2);
            btnSave.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.BorderColor = Color.FromArgb(187, 98, 2);
            btnSave.HoverState.FillColor = Color.FromArgb(187, 98, 2);
            btnSave.Location = new Point(190, 9);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.FromArgb(187, 98, 2);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(120, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextOffset = new Point(0, -2);
            btnSave.Click += btnSave_Click;
            // 
            // ucTopBar
            // 
            ucTopBar.Dock = DockStyle.Top;
            ucTopBar.Location = new Point(0, 0);
            ucTopBar.Margin = new Padding(0);
            ucTopBar.Name = "ucTopBar";
            ucTopBar.Size = new Size(906, 42);
            ucTopBar.TabIndex = 2;
            // 
            // tblParent
            // 
            tblParent.ColumnCount = 2;
            tblParent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblParent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblParent.Controls.Add(tblContent, 0, 0);
            tblParent.Controls.Add(picIllustrator, 0, 0);
            tblParent.Dock = DockStyle.Fill;
            tblParent.Location = new Point(0, 42);
            tblParent.Name = "tblParent";
            tblParent.RowCount = 1;
            tblParent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblParent.Size = new Size(906, 478);
            tblParent.TabIndex = 6;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(lblTitle, 0, 1);
            tblContent.Controls.Add(lblDescription, 0, 2);
            tblContent.Controls.Add(tblButtonAction, 0, 6);
            tblContent.Controls.Add(tbnFormContent, 0, 4);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(456, 3);
            tblContent.Name = "tblContent";
            tblContent.Padding = new Padding(40, 10, 40, 10);
            tblContent.RowCount = 8;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 168F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.Size = new Size(447, 472);
            tblContent.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(122, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "VEHICLE TYPE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(60, 93);
            lblDescription.MaximumSize = new Size(340, 0);
            lblDescription.MinimumSize = new Size(0, 32);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(326, 32);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Choose your vehicle type at Park Ease, according to the type of vehicle you park. Safe and comfortable greetings.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtonAction
            // 
            tblButtonAction.ColumnCount = 5;
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtonAction.Controls.Add(btnCancel, 1, 0);
            tblButtonAction.Controls.Add(btnSave, 3, 0);
            tblButtonAction.Dock = DockStyle.Fill;
            tblButtonAction.Location = new Point(43, 360);
            tblButtonAction.Name = "tblButtonAction";
            tblButtonAction.RowCount = 1;
            tblButtonAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtonAction.Size = new Size(361, 64);
            tblButtonAction.TabIndex = 9;
            // 
            // tbnFormContent
            // 
            tbnFormContent.ColumnCount = 4;
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.Controls.Add(lblCode, 1, 0);
            tbnFormContent.Controls.Add(lblName, 1, 1);
            tbnFormContent.Controls.Add(lblPrice, 1, 2);
            tbnFormContent.Controls.Add(txtCode, 2, 0);
            tbnFormContent.Controls.Add(txtName, 2, 1);
            tbnFormContent.Controls.Add(txtPrice, 2, 2);
            tbnFormContent.Dock = DockStyle.Fill;
            tbnFormContent.Location = new Point(40, 159);
            tbnFormContent.Margin = new Padding(0);
            tbnFormContent.Name = "tbnFormContent";
            tbnFormContent.RowCount = 1;
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.Size = new Size(367, 168);
            tbnFormContent.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Animated = true;
            txtName.BackColor = Color.Transparent;
            txtName.BorderColor = Color.FromArgb(255, 231, 70);
            txtName.BorderRadius = 8;
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = Color.FromArgb(255, 249, 197);
            txtName.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtName.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(187, 98, 2);
            txtName.HoverState.BorderColor = Color.Transparent;
            txtName.IconLeftOffset = new Point(10, 0);
            txtName.IconRightOffset = new Point(10, 0);
            txtName.Location = new Point(103, 61);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtName.PlaceholderText = "Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(261, 46);
            txtName.TabIndex = 2;
            txtName.TextOffset = new Point(10, -2);
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.None;
            txtCode.Animated = true;
            txtCode.BackColor = Color.Transparent;
            txtCode.BorderColor = Color.FromArgb(255, 231, 70);
            txtCode.BorderRadius = 8;
            txtCode.BorderThickness = 2;
            txtCode.CustomizableEdges = customizableEdges5;
            txtCode.DefaultText = "";
            txtCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCode.FillColor = Color.FromArgb(255, 249, 197);
            txtCode.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtCode.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.ForeColor = Color.FromArgb(187, 98, 2);
            txtCode.HoverState.BorderColor = Color.Transparent;
            txtCode.IconLeftOffset = new Point(10, 0);
            txtCode.IconRightOffset = new Point(10, 0);
            txtCode.Location = new Point(103, 5);
            txtCode.Margin = new Padding(0);
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtCode.PlaceholderText = "DOM001";
            txtCode.SelectedText = "";
            txtCode.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCode.Size = new Size(261, 46);
            txtCode.TabIndex = 1;
            txtCode.TextOffset = new Point(10, -2);
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Animated = true;
            txtPrice.BackColor = Color.Transparent;
            txtPrice.BorderColor = Color.FromArgb(255, 231, 70);
            txtPrice.BorderRadius = 8;
            txtPrice.BorderThickness = 2;
            txtPrice.CustomizableEdges = customizableEdges9;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FillColor = Color.FromArgb(255, 249, 197);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtPrice.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.FromArgb(187, 98, 2);
            txtPrice.HoverState.BorderColor = Color.Transparent;
            txtPrice.IconLeftOffset = new Point(10, 0);
            txtPrice.IconRightOffset = new Point(10, 0);
            txtPrice.Location = new Point(103, 117);
            txtPrice.Margin = new Padding(0);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtPrice.PlaceholderText = "Price";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPrice.Size = new Size(261, 46);
            txtPrice.TabIndex = 3;
            txtPrice.TextOffset = new Point(10, -2);
            // 
            // lblCode
            // 
            lblCode.Anchor = AnchorStyles.Left;
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.Transparent;
            lblCode.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCode.ForeColor = Color.FromArgb(187, 98, 2);
            lblCode.Location = new Point(2, 17);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(49, 21);
            lblCode.TabIndex = 7;
            lblCode.Text = "Code";
            lblCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(187, 98, 2);
            lblName.Location = new Point(2, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 21);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(187, 98, 2);
            lblPrice.Location = new Point(2, 129);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 21);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picIllustrator
            // 
            picIllustrator.BackColor = Color.FromArgb(255, 254, 234);
            picIllustrator.CustomizableEdges = customizableEdges11;
            picIllustrator.Dock = DockStyle.Fill;
            picIllustrator.Image = Properties.Resources.Parking_bro;
            picIllustrator.ImageRotate = 0F;
            picIllustrator.Location = new Point(3, 2);
            picIllustrator.Margin = new Padding(3, 2, 3, 2);
            picIllustrator.Name = "picIllustrator";
            picIllustrator.Padding = new Padding(30);
            picIllustrator.ShadowDecoration.CustomizableEdges = customizableEdges12;
            picIllustrator.Size = new Size(447, 474);
            picIllustrator.SizeMode = PictureBoxSizeMode.StretchImage;
            picIllustrator.TabIndex = 3;
            picIllustrator.TabStop = false;
            // 
            // FormVehicleType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(906, 520);
            Controls.Add(tblParent);
            Controls.Add(ucTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVehicleType";
            Text = "VehicleType";
            tblParent.ResumeLayout(false);
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            tblButtonAction.ResumeLayout(false);
            tbnFormContent.ResumeLayout(false);
            tbnFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIllustrator).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private UserControls.UC_TopBar ucTopBar;
        private TableLayoutPanel tblParent;
        private TableLayoutPanel tblContent;
        private Label lblTitle;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2PictureBox picIllustrator;
        private TableLayoutPanel tblButtonAction;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private TableLayoutPanel tbnFormContent;
        private Label lblCode;
        private Label lblName;
        private Label lblPrice;
    }
}