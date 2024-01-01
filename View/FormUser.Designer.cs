namespace ParkEase.View
{
    partial class FormUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            lblUsername = new Label();
            lblPassword = new Label();
            lblName = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            lblRole = new Label();
            lblStatus = new Label();
            cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
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
            btnCancel.CustomizableEdges = customizableEdges17;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(255, 254, 234);
            btnCancel.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(124, 62, 11);
            btnCancel.HoverState.FillColor = Color.FromArgb(255, 249, 197);
            btnCancel.Location = new Point(58, 12);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCancel.Size = new Size(137, 61);
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
            btnSave.CustomizableEdges = customizableEdges19;
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
            btnSave.Location = new Point(218, 12);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.FromArgb(187, 98, 2);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnSave.Size = new Size(137, 61);
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
            ucTopBar.Size = new Size(1035, 56);
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
            tblParent.Location = new Point(0, 56);
            tblParent.Margin = new Padding(3, 4, 3, 4);
            tblParent.Name = "tblParent";
            tblParent.RowCount = 1;
            tblParent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblParent.Size = new Size(1035, 771);
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
            tblContent.Location = new Point(520, 4);
            tblContent.Margin = new Padding(3, 4, 3, 4);
            tblContent.Name = "tblContent";
            tblContent.Padding = new Padding(46, 13, 46, 13);
            tblContent.RowCount = 8;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 373F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.Size = new Size(512, 763);
            tblContent.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(202, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "USER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(255, 254, 234);
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(66, 117);
            lblDescription.MaximumSize = new Size(389, 0);
            lblDescription.MinimumSize = new Size(0, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(379, 43);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "You are registered as a user at Park Ease, obey the rules and conditions. Safe and comfortable greetings.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtonAction
            // 
            tblButtonAction.ColumnCount = 5;
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tblButtonAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtonAction.Controls.Add(btnCancel, 1, 0);
            tblButtonAction.Controls.Add(btnSave, 3, 0);
            tblButtonAction.Dock = DockStyle.Fill;
            tblButtonAction.Location = new Point(49, 622);
            tblButtonAction.Margin = new Padding(3, 4, 3, 4);
            tblButtonAction.Name = "tblButtonAction";
            tblButtonAction.RowCount = 1;
            tblButtonAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtonAction.Size = new Size(414, 85);
            tblButtonAction.TabIndex = 9;
            // 
            // tbnFormContent
            // 
            tbnFormContent.ColumnCount = 4;
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 309F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbnFormContent.Controls.Add(lblUsername, 1, 0);
            tbnFormContent.Controls.Add(lblPassword, 1, 1);
            tbnFormContent.Controls.Add(lblName, 1, 2);
            tbnFormContent.Controls.Add(txtUsername, 2, 0);
            tbnFormContent.Controls.Add(txtPassword, 2, 1);
            tbnFormContent.Controls.Add(txtName, 2, 2);
            tbnFormContent.Controls.Add(lblRole, 1, 3);
            tbnFormContent.Controls.Add(lblStatus, 1, 4);
            tbnFormContent.Controls.Add(cmbRole, 2, 3);
            tbnFormContent.Controls.Add(cmbStatus, 2, 4);
            tbnFormContent.Dock = DockStyle.Fill;
            tbnFormContent.Location = new Point(46, 205);
            tbnFormContent.Margin = new Padding(0);
            tbnFormContent.Name = "tbnFormContent";
            tbnFormContent.RowCount = 5;
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tbnFormContent.Size = new Size(420, 373);
            tbnFormContent.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(187, 98, 2);
            lblUsername.Location = new Point(2, 11);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 52);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(187, 98, 2);
            lblPassword.Location = new Point(2, 99);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 26);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(187, 98, 2);
            lblName.Location = new Point(2, 174);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 26);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Animated = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderColor = Color.FromArgb(255, 231, 70);
            txtUsername.BorderRadius = 8;
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges21;
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
            txtUsername.IconLeftOffset = new Point(10, 0);
            txtUsername.IconRightOffset = new Point(10, 0);
            txtUsername.Location = new Point(118, 7);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtUsername.PlaceholderText = "pajio";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtUsername.Size = new Size(298, 61);
            txtUsername.TabIndex = 1;
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
            txtPassword.CustomizableEdges = customizableEdges23;
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
            txtPassword.IconLeftOffset = new Point(10, 0);
            txtPassword.IconRightOffset = new Point(10, 0);
            txtPassword.Location = new Point(118, 82);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtPassword.Size = new Size(298, 61);
            txtPassword.TabIndex = 2;
            txtPassword.TextOffset = new Point(10, -2);
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Animated = true;
            txtName.BackColor = Color.Transparent;
            txtName.BorderColor = Color.FromArgb(255, 231, 70);
            txtName.BorderRadius = 8;
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges25;
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
            txtName.Location = new Point(118, 157);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtName.PlaceholderText = "Paijo Royo Royo";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtName.Size = new Size(298, 61);
            txtName.TabIndex = 3;
            txtName.TextOffset = new Point(10, -2);
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Left;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(187, 98, 2);
            lblRole.Location = new Point(2, 249);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 26);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(187, 98, 2);
            lblStatus.Location = new Point(2, 324);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 26);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.BackColor = Color.Transparent;
            cmbRole.BorderColor = Color.FromArgb(255, 231, 70);
            cmbRole.BorderRadius = 8;
            cmbRole.BorderThickness = 2;
            cmbRole.Cursor = Cursors.Hand;
            cmbRole.CustomizableEdges = customizableEdges27;
            cmbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FillColor = Color.FromArgb(255, 249, 197);
            cmbRole.FocusedColor = Color.FromArgb(226, 139, 0);
            cmbRole.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            cmbRole.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRole.ForeColor = Color.FromArgb(187, 98, 2);
            cmbRole.ItemHeight = 40;
            cmbRole.Location = new Point(118, 239);
            cmbRole.Margin = new Padding(0);
            cmbRole.Name = "cmbRole";
            cmbRole.ShadowDecoration.CustomizableEdges = customizableEdges28;
            cmbRole.Size = new Size(298, 46);
            cmbRole.TabIndex = 4;
            cmbRole.TextOffset = new Point(10, -2);
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.BackColor = Color.Transparent;
            cmbStatus.BorderColor = Color.FromArgb(255, 231, 70);
            cmbStatus.BorderRadius = 8;
            cmbStatus.BorderThickness = 2;
            cmbStatus.Cursor = Cursors.Hand;
            cmbStatus.CustomizableEdges = customizableEdges29;
            cmbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FillColor = Color.FromArgb(255, 249, 197);
            cmbStatus.FocusedColor = Color.FromArgb(226, 139, 0);
            cmbStatus.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            cmbStatus.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.ForeColor = Color.FromArgb(187, 98, 2);
            cmbStatus.ItemHeight = 40;
            cmbStatus.Location = new Point(118, 314);
            cmbStatus.Margin = new Padding(0);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.ShadowDecoration.CustomizableEdges = customizableEdges30;
            cmbStatus.Size = new Size(298, 46);
            cmbStatus.TabIndex = 4;
            cmbStatus.TextOffset = new Point(10, -2);
            // 
            // picIllustrator
            // 
            picIllustrator.BackColor = Color.FromArgb(255, 254, 234);
            picIllustrator.CustomizableEdges = customizableEdges31;
            picIllustrator.Dock = DockStyle.Fill;
            picIllustrator.Image = Properties.Resources.picture_users;
            picIllustrator.ImageRotate = 0F;
            picIllustrator.Location = new Point(3, 3);
            picIllustrator.Name = "picIllustrator";
            picIllustrator.Padding = new Padding(34, 40, 34, 40);
            picIllustrator.ShadowDecoration.CustomizableEdges = customizableEdges32;
            picIllustrator.Size = new Size(511, 765);
            picIllustrator.SizeMode = PictureBoxSizeMode.StretchImage;
            picIllustrator.TabIndex = 3;
            picIllustrator.TabStop = false;
            // 
            // dragControl
            // 
            dragControl.DockForm = true;
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.UseTransparentDrag = true;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            ClientSize = new Size(1035, 827);
            Controls.Add(tblParent);
            Controls.Add(ucTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
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
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2PictureBox picIllustrator;
        private TableLayoutPanel tblButtonAction;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private TableLayoutPanel tbnFormContent;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblName;
        private Label lblRole;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}