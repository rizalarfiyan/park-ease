namespace ParkEase.View
{
    partial class FormSetting
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tblWrapper = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            tblAction = new TableLayoutPanel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            tbnFormContent = new TableLayoutPanel();
            lblFineTicketCalculation = new Label();
            lblNextHourCalculation = new Label();
            tblFineTicketCalculation = new TableLayoutPanel();
            txtFineTicketCalculation = new Guna.UI2.WinForms.Guna2TextBox();
            lblFineTicketCalculationDescription = new Label();
            tblNextHourCalculation = new TableLayoutPanel();
            txtNextHourCalculation = new Guna.UI2.WinForms.Guna2TextBox();
            lblNextHourCalculationDescription = new Label();
            tblWrapper.SuspendLayout();
            tblAction.SuspendLayout();
            tbnFormContent.SuspendLayout();
            tblFineTicketCalculation.SuspendLayout();
            tblNextHourCalculation.SuspendLayout();
            SuspendLayout();
            // 
            // tblWrapper
            // 
            tblWrapper.ColumnCount = 1;
            tblWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblWrapper.Controls.Add(lblTitle, 0, 0);
            tblWrapper.Controls.Add(lblDescription, 0, 1);
            tblWrapper.Controls.Add(tblAction, 0, 5);
            tblWrapper.Controls.Add(tbnFormContent, 1, 3);
            tblWrapper.Dock = DockStyle.Fill;
            tblWrapper.Location = new Point(0, 0);
            tblWrapper.Name = "tblWrapper";
            tblWrapper.RowCount = 7;
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 192F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblWrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblWrapper.Size = new Size(800, 400);
            tblWrapper.TabIndex = 17;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 40);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "SETTING";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.ImageAlign = ContentAlignment.MiddleLeft;
            lblDescription.Location = new Point(3, 44);
            lblDescription.MaximumSize = new Size(480, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(428, 32);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Easily simplify your parking operations – settings and optimize your parking solutions.";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblAction
            // 
            tblAction.ColumnCount = 5;
            tblAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAction.Controls.Add(btnSave, 3, 0);
            tblAction.Controls.Add(btnCancel, 1, 0);
            tblAction.Dock = DockStyle.Bottom;
            tblAction.Location = new Point(3, 335);
            tblAction.Name = "tblAction";
            tblAction.RowCount = 1;
            tblAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAction.Size = new Size(794, 50);
            tblAction.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.BorderColor = Color.FromArgb(226, 139, 0);
            btnSave.BorderRadius = 8;
            btnSave.BorderThickness = 2;
            btnSave.CheckedState.FillColor = Color.FromArgb(187, 98, 2);
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomizableEdges = customizableEdges13;
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
            btnSave.Location = new Point(407, 2);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.FromArgb(187, 98, 2);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSave.Size = new Size(120, 46);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.TextOffset = new Point(0, -2);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(255, 254, 234);
            btnCancel.BorderRadius = 8;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomizableEdges = customizableEdges15;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(255, 254, 234);
            btnCancel.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(124, 62, 11);
            btnCancel.HoverState.FillColor = Color.FromArgb(255, 249, 197);
            btnCancel.Location = new Point(267, 2);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.TextOffset = new Point(0, -2);
            btnCancel.Click += btnCancel_Click;
            // 
            // tbnFormContent
            // 
            tbnFormContent.ColumnCount = 2;
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tbnFormContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbnFormContent.Controls.Add(lblFineTicketCalculation, 0, 0);
            tbnFormContent.Controls.Add(lblNextHourCalculation, 0, 1);
            tbnFormContent.Controls.Add(tblFineTicketCalculation, 1, 0);
            tbnFormContent.Controls.Add(tblNextHourCalculation, 1, 1);
            tbnFormContent.Dock = DockStyle.Fill;
            tbnFormContent.Location = new Point(0, 110);
            tbnFormContent.Margin = new Padding(0);
            tbnFormContent.Name = "tbnFormContent";
            tbnFormContent.RowCount = 2;
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tbnFormContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tbnFormContent.Size = new Size(800, 192);
            tbnFormContent.TabIndex = 19;
            // 
            // lblFineTicketCalculation
            // 
            lblFineTicketCalculation.AutoSize = true;
            lblFineTicketCalculation.BackColor = Color.Transparent;
            lblFineTicketCalculation.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFineTicketCalculation.ForeColor = Color.FromArgb(187, 98, 2);
            lblFineTicketCalculation.Location = new Point(3, 16);
            lblFineTicketCalculation.Margin = new Padding(3, 16, 3, 0);
            lblFineTicketCalculation.Name = "lblFineTicketCalculation";
            lblFineTicketCalculation.Size = new Size(177, 21);
            lblFineTicketCalculation.TabIndex = 7;
            lblFineTicketCalculation.Text = "Fine Ticket Calculation";
            lblFineTicketCalculation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNextHourCalculation
            // 
            lblNextHourCalculation.AutoSize = true;
            lblNextHourCalculation.BackColor = Color.Transparent;
            lblNextHourCalculation.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNextHourCalculation.ForeColor = Color.FromArgb(187, 98, 2);
            lblNextHourCalculation.Location = new Point(3, 112);
            lblNextHourCalculation.Margin = new Padding(3, 16, 3, 0);
            lblNextHourCalculation.Name = "lblNextHourCalculation";
            lblNextHourCalculation.Size = new Size(175, 21);
            lblNextHourCalculation.TabIndex = 7;
            lblNextHourCalculation.Text = "Next Hour Calculation";
            lblNextHourCalculation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblFineTicketCalculation
            // 
            tblFineTicketCalculation.ColumnCount = 1;
            tblFineTicketCalculation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblFineTicketCalculation.Controls.Add(txtFineTicketCalculation, 0, 0);
            tblFineTicketCalculation.Controls.Add(lblFineTicketCalculationDescription, 0, 1);
            tblFineTicketCalculation.Dock = DockStyle.Fill;
            tblFineTicketCalculation.Location = new Point(223, 3);
            tblFineTicketCalculation.Name = "tblFineTicketCalculation";
            tblFineTicketCalculation.RowCount = 2;
            tblFineTicketCalculation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFineTicketCalculation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFineTicketCalculation.Size = new Size(574, 90);
            tblFineTicketCalculation.TabIndex = 8;
            // 
            // txtFineTicketCalculation
            // 
            txtFineTicketCalculation.Anchor = AnchorStyles.Left;
            txtFineTicketCalculation.Animated = true;
            txtFineTicketCalculation.BackColor = Color.Transparent;
            txtFineTicketCalculation.BorderColor = Color.FromArgb(255, 231, 70);
            txtFineTicketCalculation.BorderRadius = 8;
            txtFineTicketCalculation.BorderThickness = 2;
            txtFineTicketCalculation.CustomizableEdges = customizableEdges17;
            txtFineTicketCalculation.DefaultText = "";
            txtFineTicketCalculation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFineTicketCalculation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFineTicketCalculation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFineTicketCalculation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFineTicketCalculation.FillColor = Color.FromArgb(255, 249, 197);
            txtFineTicketCalculation.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtFineTicketCalculation.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFineTicketCalculation.ForeColor = Color.FromArgb(187, 98, 2);
            txtFineTicketCalculation.HoverState.BorderColor = Color.Transparent;
            txtFineTicketCalculation.IconLeftOffset = new Point(10, 0);
            txtFineTicketCalculation.IconRightOffset = new Point(10, 0);
            txtFineTicketCalculation.Location = new Point(0, 0);
            txtFineTicketCalculation.Margin = new Padding(0);
            txtFineTicketCalculation.Name = "txtFineTicketCalculation";
            txtFineTicketCalculation.PasswordChar = '\0';
            txtFineTicketCalculation.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtFineTicketCalculation.PlaceholderText = "100";
            txtFineTicketCalculation.SelectedText = "";
            txtFineTicketCalculation.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtFineTicketCalculation.Size = new Size(300, 45);
            txtFineTicketCalculation.TabIndex = 2;
            txtFineTicketCalculation.TextOffset = new Point(10, -2);
            // 
            // lblFineTicketCalculationDescription
            // 
            lblFineTicketCalculationDescription.Anchor = AnchorStyles.Left;
            lblFineTicketCalculationDescription.AutoSize = true;
            lblFineTicketCalculationDescription.BackColor = Color.Transparent;
            lblFineTicketCalculationDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFineTicketCalculationDescription.ForeColor = SystemColors.ControlDarkDark;
            lblFineTicketCalculationDescription.ImageAlign = ContentAlignment.MiddleLeft;
            lblFineTicketCalculationDescription.Location = new Point(3, 59);
            lblFineTicketCalculationDescription.MaximumSize = new Size(470, 0);
            lblFineTicketCalculationDescription.Name = "lblFineTicketCalculationDescription";
            lblFineTicketCalculationDescription.Size = new Size(53, 16);
            lblFineTicketCalculationDescription.TabIndex = 8;
            lblFineTicketCalculationDescription.Text = "No note";
            lblFineTicketCalculationDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblNextHourCalculation
            // 
            tblNextHourCalculation.ColumnCount = 1;
            tblNextHourCalculation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblNextHourCalculation.Controls.Add(txtNextHourCalculation, 0, 0);
            tblNextHourCalculation.Controls.Add(lblNextHourCalculationDescription, 0, 1);
            tblNextHourCalculation.Dock = DockStyle.Fill;
            tblNextHourCalculation.Location = new Point(223, 99);
            tblNextHourCalculation.Name = "tblNextHourCalculation";
            tblNextHourCalculation.RowCount = 2;
            tblNextHourCalculation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblNextHourCalculation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblNextHourCalculation.Size = new Size(574, 90);
            tblNextHourCalculation.TabIndex = 8;
            // 
            // txtNextHourCalculation
            // 
            txtNextHourCalculation.Anchor = AnchorStyles.Left;
            txtNextHourCalculation.Animated = true;
            txtNextHourCalculation.BackColor = Color.Transparent;
            txtNextHourCalculation.BorderColor = Color.FromArgb(255, 231, 70);
            txtNextHourCalculation.BorderRadius = 8;
            txtNextHourCalculation.BorderThickness = 2;
            txtNextHourCalculation.CustomizableEdges = customizableEdges19;
            txtNextHourCalculation.DefaultText = "";
            txtNextHourCalculation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNextHourCalculation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNextHourCalculation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNextHourCalculation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNextHourCalculation.FillColor = Color.FromArgb(255, 249, 197);
            txtNextHourCalculation.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            txtNextHourCalculation.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNextHourCalculation.ForeColor = Color.FromArgb(187, 98, 2);
            txtNextHourCalculation.HoverState.BorderColor = Color.Transparent;
            txtNextHourCalculation.IconLeftOffset = new Point(10, 0);
            txtNextHourCalculation.IconRightOffset = new Point(10, 0);
            txtNextHourCalculation.Location = new Point(0, 0);
            txtNextHourCalculation.Margin = new Padding(0);
            txtNextHourCalculation.Name = "txtNextHourCalculation";
            txtNextHourCalculation.PasswordChar = '\0';
            txtNextHourCalculation.PlaceholderForeColor = Color.FromArgb(255, 183, 3);
            txtNextHourCalculation.PlaceholderText = "100";
            txtNextHourCalculation.SelectedText = "";
            txtNextHourCalculation.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtNextHourCalculation.Size = new Size(300, 45);
            txtNextHourCalculation.TabIndex = 2;
            txtNextHourCalculation.TextOffset = new Point(10, -2);
            // 
            // lblNextHourCalculationDescription
            // 
            lblNextHourCalculationDescription.Anchor = AnchorStyles.Left;
            lblNextHourCalculationDescription.AutoSize = true;
            lblNextHourCalculationDescription.BackColor = Color.Transparent;
            lblNextHourCalculationDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextHourCalculationDescription.ForeColor = SystemColors.ControlDarkDark;
            lblNextHourCalculationDescription.ImageAlign = ContentAlignment.MiddleLeft;
            lblNextHourCalculationDescription.Location = new Point(3, 59);
            lblNextHourCalculationDescription.MaximumSize = new Size(470, 0);
            lblNextHourCalculationDescription.Name = "lblNextHourCalculationDescription";
            lblNextHourCalculationDescription.Size = new Size(53, 16);
            lblNextHourCalculationDescription.TabIndex = 8;
            lblNextHourCalculationDescription.Text = "No note";
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 400);
            Controls.Add(tblWrapper);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetting";
            Text = "Setting";
            tblWrapper.ResumeLayout(false);
            tblWrapper.PerformLayout();
            tblAction.ResumeLayout(false);
            tbnFormContent.ResumeLayout(false);
            tbnFormContent.PerformLayout();
            tblFineTicketCalculation.ResumeLayout(false);
            tblFineTicketCalculation.PerformLayout();
            tblNextHourCalculation.ResumeLayout(false);
            tblNextHourCalculation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblWrapper;
        private Label lblTitle;
        private Label lblDescription;
        private TableLayoutPanel tblAction;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private TableLayoutPanel tbnFormContent;
        private Label lblFineTicketCalculation;
        private Label lblNextHourCalculation;
        private Guna.UI2.WinForms.Guna2TextBox txtFineTicketCalculation;
        private TableLayoutPanel tblFineTicketCalculation;
        private Label lblFineTicketCalculationDescription;
        private TableLayoutPanel tblNextHourCalculation;
        private Guna.UI2.WinForms.Guna2TextBox txtNextHourCalculation;
        private Label lblNextHourCalculationDescription;
    }
}