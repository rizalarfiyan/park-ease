namespace ParkEase.View
{
    partial class FormEntryHistory
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
            lblVehicleNumber = new Label();
            lblVehicleType = new Label();
            lblLocation = new Label();
            txtVehicleNumber = new Guna.UI2.WinForms.Guna2TextBox();
            cmbVehicleType = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            picIllustrator = new Guna.UI2.WinForms.Guna2PictureBox();
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
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
            btnCancel.Location = new Point(74, 9);
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
            btnSave.Location = new Point(214, 9);
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
            ucTopBar.Size = new Size(1000, 42);
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
            tblParent.Size = new Size(1000, 478);
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
            tblContent.Location = new Point(503, 3);
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
            tblContent.Size = new Size(494, 472);
            tblContent.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(79, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(335, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CREATE ENTRY HISTORY";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(84, 93);
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
            tblButtonAction.Size = new Size(408, 64);
            tblButtonAction.TabIndex = 9;
            // 
            // tbnFormContent
            // 
            tbnFormContent.ColumnCount = 4;
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.Controls.Add(lblVehicleNumber, 1, 0);
            tbnFormContent.Controls.Add(lblVehicleType, 1, 1);
            tbnFormContent.Controls.Add(lblLocation, 1, 2);
            tbnFormContent.Controls.Add(txtVehicleNumber, 2, 0);
            tbnFormContent.Controls.Add(cmbVehicleType, 2, 1);
            tbnFormContent.Controls.Add(cmbLocation, 2, 2);
            tbnFormContent.Dock = DockStyle.Fill;
            tbnFormContent.Location = new Point(40, 159);
            tbnFormContent.Margin = new Padding(0);
            tbnFormContent.Name = "tbnFormContent";
            tbnFormContent.RowCount = 3;
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tbnFormContent.Size = new Size(414, 168);
            tbnFormContent.TabIndex = 10;
            // 
            // lblVehicleNumber
            // 
            lblVehicleNumber.Anchor = AnchorStyles.Left;
            lblVehicleNumber.AutoSize = true;
            lblVehicleNumber.BackColor = Color.Transparent;
            lblVehicleNumber.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVehicleNumber.ForeColor = Color.FromArgb(187, 98, 2);
            lblVehicleNumber.Location = new Point(5, 17);
            lblVehicleNumber.Name = "lblVehicleNumber";
            lblVehicleNumber.Size = new Size(126, 21);
            lblVehicleNumber.TabIndex = 7;
            lblVehicleNumber.Text = "Vehicle Number";
            lblVehicleNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVehicleType
            // 
            lblVehicleType.Anchor = AnchorStyles.Left;
            lblVehicleType.AutoSize = true;
            lblVehicleType.BackColor = Color.Transparent;
            lblVehicleType.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVehicleType.ForeColor = Color.FromArgb(187, 98, 2);
            lblVehicleType.Location = new Point(5, 73);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(101, 21);
            lblVehicleType.TabIndex = 7;
            lblVehicleType.Text = "Vehicle Type";
            lblVehicleType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            lblLocation.Anchor = AnchorStyles.Left;
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocation.ForeColor = Color.FromArgb(187, 98, 2);
            lblLocation.Location = new Point(5, 129);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(76, 21);
            lblLocation.TabIndex = 7;
            lblLocation.Text = "Location";
            lblLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Anchor = AnchorStyles.None;
            txtVehicleNumber.Animated = true;
            txtVehicleNumber.BackColor = Color.Transparent;
            txtVehicleNumber.BorderColor = Color.FromArgb(255, 231, 70);
            txtVehicleNumber.BorderRadius = 8;
            txtVehicleNumber.BorderThickness = 2;
            txtVehicleNumber.CustomizableEdges = customizableEdges5;
            txtVehicleNumber.DefaultText = "";
            txtVehicleNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtVehicleNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtVehicleNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtVehicleNumber.FillColor = Color.FromArgb(255, 249, 197);
            txtVehicleNumber.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtVehicleNumber.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVehicleNumber.ForeColor = Color.FromArgb(187, 98, 2);
            txtVehicleNumber.HoverState.BorderColor = Color.Transparent;
            txtVehicleNumber.IconLeftOffset = new Point(10, 0);
            txtVehicleNumber.IconRightOffset = new Point(10, 0);
            txtVehicleNumber.Location = new Point(146, 5);
            txtVehicleNumber.Margin = new Padding(0);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.PasswordChar = '\0';
            txtVehicleNumber.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtVehicleNumber.PlaceholderText = "AB1234NZ";
            txtVehicleNumber.SelectedText = "";
            txtVehicleNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtVehicleNumber.Size = new Size(261, 46);
            txtVehicleNumber.TabIndex = 1;
            txtVehicleNumber.TextOffset = new Point(10, -2);
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.Anchor = AnchorStyles.None;
            cmbVehicleType.BackColor = Color.Transparent;
            cmbVehicleType.BorderColor = Color.FromArgb(255, 231, 70);
            cmbVehicleType.BorderRadius = 8;
            cmbVehicleType.BorderThickness = 2;
            cmbVehicleType.Cursor = Cursors.Hand;
            cmbVehicleType.CustomizableEdges = customizableEdges7;
            cmbVehicleType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FillColor = Color.FromArgb(255, 249, 197);
            cmbVehicleType.FocusedColor = Color.FromArgb(226, 139, 0);
            cmbVehicleType.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            cmbVehicleType.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVehicleType.ForeColor = Color.FromArgb(187, 98, 2);
            cmbVehicleType.ItemHeight = 40;
            cmbVehicleType.Location = new Point(146, 61);
            cmbVehicleType.Margin = new Padding(0);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbVehicleType.Size = new Size(261, 46);
            cmbVehicleType.TabIndex = 2;
            cmbVehicleType.TextOffset = new Point(10, -2);
            // 
            // cmbLocation
            // 
            cmbLocation.Anchor = AnchorStyles.None;
            cmbLocation.BackColor = Color.Transparent;
            cmbLocation.BorderColor = Color.FromArgb(255, 231, 70);
            cmbLocation.BorderRadius = 8;
            cmbLocation.BorderThickness = 2;
            cmbLocation.Cursor = Cursors.Hand;
            cmbLocation.CustomizableEdges = customizableEdges9;
            cmbLocation.DrawMode = DrawMode.OwnerDrawFixed;
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.FillColor = Color.FromArgb(255, 249, 197);
            cmbLocation.FocusedColor = Color.FromArgb(226, 139, 0);
            cmbLocation.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            cmbLocation.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLocation.ForeColor = Color.FromArgb(187, 98, 2);
            cmbLocation.ItemHeight = 40;
            cmbLocation.Location = new Point(146, 117);
            cmbLocation.Margin = new Padding(0);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbLocation.Size = new Size(261, 46);
            cmbLocation.TabIndex = 3;
            cmbLocation.TextOffset = new Point(10, -2);
            // 
            // picIllustrator
            // 
            picIllustrator.BackColor = Color.FromArgb(255, 254, 234);
            picIllustrator.CustomizableEdges = customizableEdges11;
            picIllustrator.Dock = DockStyle.Fill;
            picIllustrator.Image = Properties.Resources.picture_entry;
            picIllustrator.ImageRotate = 0F;
            picIllustrator.Location = new Point(3, 2);
            picIllustrator.Margin = new Padding(3, 2, 3, 2);
            picIllustrator.Name = "picIllustrator";
            picIllustrator.Padding = new Padding(30);
            picIllustrator.ShadowDecoration.CustomizableEdges = customizableEdges12;
            picIllustrator.Size = new Size(494, 474);
            picIllustrator.SizeMode = PictureBoxSizeMode.StretchImage;
            picIllustrator.TabIndex = 3;
            picIllustrator.TabStop = false;
            // 
            // dragControl
            // 
            dragControl.DockForm = true;
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = tblContent;
            dragControl.UseTransparentDrag = true;
            // 
            // FormEntryHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(1000, 520);
            Controls.Add(tblParent);
            Controls.Add(ucTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEntryHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Entry History";
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
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleNumber;
        private Guna.UI2.WinForms.Guna2PictureBox picIllustrator;
        private TableLayoutPanel tblButtonAction;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private TableLayoutPanel tbnFormContent;
        private Label lblVehicleNumber;
        private Label lblVehicleType;
        private Label lblLocation;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVehicleType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLocation;
    }
}