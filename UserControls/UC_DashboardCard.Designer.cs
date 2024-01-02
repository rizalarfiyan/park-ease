namespace ParkEase.UserControls
{
    partial class UCDashboardCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlContentCard = new Guna.UI2.WinForms.Guna2Panel();
            tblContent = new TableLayoutPanel();
            lblDescription = new Label();
            lblValue = new Label();
            tblTitle = new TableLayoutPanel();
            imgIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitle = new Label();
            pnlContentCard.SuspendLayout();
            tblContent.SuspendLayout();
            tblTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlContentCard
            // 
            pnlContentCard.BorderColor = Color.FromArgb(226, 139, 0);
            pnlContentCard.BorderRadius = 12;
            pnlContentCard.BorderThickness = 2;
            pnlContentCard.Controls.Add(tblContent);
            pnlContentCard.CustomizableEdges = customizableEdges5;
            pnlContentCard.Dock = DockStyle.Fill;
            pnlContentCard.ForeColor = SystemColors.ControlText;
            pnlContentCard.Location = new Point(0, 0);
            pnlContentCard.Margin = new Padding(3, 2, 3, 2);
            pnlContentCard.Name = "pnlContentCard";
            pnlContentCard.Padding = new Padding(10);
            pnlContentCard.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlContentCard.Size = new Size(192, 115);
            pnlContentCard.TabIndex = 4;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(lblDescription, 0, 3);
            tblContent.Controls.Add(lblValue, 0, 2);
            tblContent.Controls.Add(tblTitle, 0, 1);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(10, 10);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 5;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblContent.Size = new Size(172, 95);
            tblContent.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Ubuntu", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(3, 73);
            lblDescription.MaximumSize = new Size(140, 16);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(134, 16);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "+23% from last month";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValue
            // 
            lblValue.Anchor = AnchorStyles.Left;
            lblValue.AutoSize = true;
            lblValue.BackColor = Color.Transparent;
            lblValue.Font = new Font("Ubuntu", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblValue.ForeColor = Color.FromArgb(64, 64, 64);
            lblValue.Location = new Point(3, 36);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(142, 27);
            lblValue.TabIndex = 24;
            lblValue.Text = "Rp65.000,00";
            lblValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblTitle
            // 
            tblTitle.ColumnCount = 2;
            tblTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tblTitle.Controls.Add(imgIcon, 1, 0);
            tblTitle.Controls.Add(lblTitle, 0, 0);
            tblTitle.Dock = DockStyle.Fill;
            tblTitle.Location = new Point(0, 4);
            tblTitle.Margin = new Padding(0);
            tblTitle.Name = "tblTitle";
            tblTitle.RowCount = 1;
            tblTitle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTitle.Size = new Size(172, 24);
            tblTitle.TabIndex = 25;
            // 
            // imgIcon
            // 
            imgIcon.Anchor = AnchorStyles.Right;
            imgIcon.CustomizableEdges = customizableEdges7;
            imgIcon.Image = Properties.Resources.icon_money;
            imgIcon.ImageRotate = 0F;
            imgIcon.Location = new Point(151, 3);
            imgIcon.Margin = new Padding(3, 0, 3, 0);
            imgIcon.Name = "imgIcon";
            imgIcon.ShadowDecoration.CustomizableEdges = customizableEdges8;
            imgIcon.Size = new Size(18, 18);
            imgIcon.TabIndex = 23;
            imgIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(226, 139, 0);
            lblTitle.ImageAlign = ContentAlignment.MiddleRight;
            lblTitle.Location = new Point(3, 3);
            lblTitle.MaximumSize = new Size(0, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 18);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Total Revenue";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCDashboardCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContentCard);
            Name = "UCDashboardCard";
            Size = new Size(192, 115);
            pnlContentCard.ResumeLayout(false);
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            tblTitle.ResumeLayout(false);
            tblTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContentCard;
        private TableLayoutPanel tblContent;
        private Label lblDescription;
        private Label lblValue;
        private TableLayoutPanel tblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox imgIcon;
        private Label lblTitle;
    }
}
