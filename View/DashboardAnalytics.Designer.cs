namespace ParkEase.View
{
    partial class DashboardAnalytics
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAnalytics));
            tblTitle = new TableLayoutPanel();
            lblTitle = new Label();
            lblDescription = new Label();
            tblContent = new TableLayoutPanel();
            chartDashboard = new Guna.Charts.WinForms.GunaChart();
            dataRevenue = new Guna.Charts.WinForms.GunaSplineDataset();
            dataVehicle = new Guna.Charts.WinForms.GunaSplineDataset();
            tblHeader = new TableLayoutPanel();
            cmbTimeFrequency = new Guna.UI2.WinForms.Guna2ComboBox();
            tblCardWrapper = new TableLayoutPanel();
            cardTotalRevenue = new UserControls.UCDashboardCard();
            cardAvailableSpace = new UserControls.UCDashboardCard();
            cardExitGateway = new UserControls.UCDashboardCard();
            cardFineReport = new UserControls.UCDashboardCard();
            tblTitle.SuspendLayout();
            tblContent.SuspendLayout();
            tblHeader.SuspendLayout();
            tblCardWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // tblTitle
            // 
            tblTitle.ColumnCount = 1;
            tblTitle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTitle.Controls.Add(lblTitle, 0, 0);
            tblTitle.Controls.Add(lblDescription, 0, 1);
            tblTitle.Dock = DockStyle.Fill;
            tblTitle.Location = new Point(3, 3);
            tblTitle.Name = "tblTitle";
            tblTitle.RowCount = 2;
            tblTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblTitle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblTitle.Size = new Size(598, 58);
            tblTitle.TabIndex = 17;
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
            lblTitle.Size = new Size(220, 40);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "DASHBOARD";
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
            lblDescription.Size = new Size(475, 32);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry.";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(chartDashboard, 0, 4);
            tblContent.Controls.Add(tblHeader, 0, 0);
            tblContent.Controls.Add(tblCardWrapper, 0, 2);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(0, 0);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 5;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblContent.Size = new Size(800, 520);
            tblContent.TabIndex = 0;
            // 
            // chartDashboard
            // 
            chartDashboard.Cursor = Cursors.Hand;
            chartDashboard.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { dataRevenue, dataVehicle });
            chartDashboard.Dock = DockStyle.Fill;
            chartFont1.FontName = "Ubuntu";
            chartDashboard.Legend.LabelFont = chartFont1;
            chartDashboard.Location = new Point(4, 243);
            chartDashboard.Margin = new Padding(4, 3, 4, 3);
            chartDashboard.Name = "chartDashboard";
            chartDashboard.Size = new Size(792, 274);
            chartDashboard.TabIndex = 23;
            chartDashboard.Title.Display = false;
            chartFont2.FontName = "Ubuntu";
            chartFont2.Size = 9;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            chartDashboard.Title.Font = chartFont2;
            chartDashboard.Title.ForeColor = Color.FromArgb(226, 139, 0);
            chartDashboard.Tooltips.BackgroundColor = Color.FromArgb(226, 139, 0);
            chartFont3.FontName = "Ubuntu";
            chartFont3.Size = 9;
            chartFont3.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            chartDashboard.Tooltips.BodyFont = chartFont3;
            chartDashboard.Tooltips.BorderColor = Color.FromArgb(226, 139, 0);
            chartFont4.FontName = "Ubuntu";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            chartDashboard.Tooltips.TitleFont = chartFont4;
            grid1.Color = Color.FromArgb(255, 231, 70);
            grid1.ZeroLineColor = Color.FromArgb(255, 231, 70);
            chartDashboard.XAxes.GridLines = grid1;
            chartFont5.FontName = "Ubuntu";
            tick1.Font = chartFont5;
            tick1.ForeColor = Color.FromArgb(226, 139, 0);
            chartDashboard.XAxes.Ticks = tick1;
            chartDashboard.YAxes.Display = false;
            grid2.Color = Color.FromArgb(226, 139, 0);
            grid2.ZeroLineColor = Color.FromArgb(226, 139, 0);
            chartDashboard.YAxes.GridLines = grid2;
            chartFont6.FontName = "Ubuntu";
            tick2.Font = chartFont6;
            tick2.ForeColor = Color.FromArgb(226, 139, 0);
            chartDashboard.YAxes.Ticks = tick2;
            chartDashboard.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            chartDashboard.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            chartDashboard.ZAxes.Ticks = tick3;
            // 
            // dataRevenue
            // 
            dataRevenue.BorderColor = Color.FromArgb(226, 139, 0);
            dataRevenue.FillColor = Color.FromArgb(226, 139, 0);
            dataRevenue.IndexLabelForeColor = Color.FromArgb(226, 139, 0);
            dataRevenue.Label = "Revenue";
            dataRevenue.LegendBoxBorderColor = Color.FromArgb(226, 139, 0);
            dataRevenue.LegendBoxFillColor = Color.FromArgb(226, 139, 0);
            dataRevenue.TargetChart = chartDashboard;
            // 
            // dataVehicle
            // 
            dataVehicle.BorderColor = Color.DimGray;
            dataVehicle.FillColor = Color.DimGray;
            dataVehicle.IndexLabelForeColor = Color.DimGray;
            dataVehicle.Label = "Vehicle";
            dataVehicle.LegendBoxBorderColor = Color.DimGray;
            dataVehicle.LegendBoxFillColor = Color.DimGray;
            dataVehicle.TargetChart = chartDashboard;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tblHeader.Controls.Add(cmbTimeFrequency, 1, 0);
            tblHeader.Controls.Add(tblTitle, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(3, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(794, 84);
            tblHeader.TabIndex = 0;
            // 
            // cmbTimeFrequency
            // 
            cmbTimeFrequency.Anchor = AnchorStyles.Right;
            cmbTimeFrequency.BackColor = Color.Transparent;
            cmbTimeFrequency.BorderColor = Color.FromArgb(255, 231, 70);
            cmbTimeFrequency.BorderRadius = 8;
            cmbTimeFrequency.BorderThickness = 2;
            cmbTimeFrequency.Cursor = Cursors.Hand;
            cmbTimeFrequency.CustomizableEdges = customizableEdges1;
            cmbTimeFrequency.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTimeFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimeFrequency.FillColor = Color.FromArgb(255, 249, 197);
            cmbTimeFrequency.FocusedColor = Color.FromArgb(226, 139, 0);
            cmbTimeFrequency.FocusedState.BorderColor = Color.FromArgb(226, 139, 0);
            cmbTimeFrequency.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTimeFrequency.ForeColor = Color.FromArgb(187, 98, 2);
            cmbTimeFrequency.ItemHeight = 40;
            cmbTimeFrequency.Location = new Point(614, 9);
            cmbTimeFrequency.Margin = new Padding(0);
            cmbTimeFrequency.Name = "cmbTimeFrequency";
            cmbTimeFrequency.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cmbTimeFrequency.Size = new Size(180, 46);
            cmbTimeFrequency.TabIndex = 22;
            cmbTimeFrequency.TextOffset = new Point(10, -2);
            cmbTimeFrequency.SelectedIndexChanged += onTimeFramChange;
            // 
            // tblCardWrapper
            // 
            tblCardWrapper.ColumnCount = 7;
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tblCardWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardWrapper.Controls.Add(cardTotalRevenue, 0, 0);
            tblCardWrapper.Controls.Add(cardAvailableSpace, 2, 0);
            tblCardWrapper.Controls.Add(cardExitGateway, 4, 0);
            tblCardWrapper.Controls.Add(cardFineReport, 6, 0);
            tblCardWrapper.Dock = DockStyle.Fill;
            tblCardWrapper.Location = new Point(3, 103);
            tblCardWrapper.Name = "tblCardWrapper";
            tblCardWrapper.RowCount = 1;
            tblCardWrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCardWrapper.Size = new Size(794, 124);
            tblCardWrapper.TabIndex = 1;
            // 
            // cardTotalRevenue
            // 
            cardTotalRevenue.CardDescription = "";
            cardTotalRevenue.CardIcon = (Image)resources.GetObject("cardTotalRevenue.CardIcon");
            cardTotalRevenue.CardValue = "-";
            cardTotalRevenue.Dock = DockStyle.Fill;
            cardTotalRevenue.Location = new Point(3, 3);
            cardTotalRevenue.Name = "cardTotalRevenue";
            cardTotalRevenue.Size = new Size(185, 118);
            cardTotalRevenue.TabIndex = 0;
            // 
            // cardAvailableSpace
            // 
            cardAvailableSpace.CardDescription = "";
            cardAvailableSpace.CardIcon = Properties.Resources.icon_available_card;
            cardAvailableSpace.CardTitle = "Available Space";
            cardAvailableSpace.CardValue = "-";
            cardAvailableSpace.Dock = DockStyle.Fill;
            cardAvailableSpace.Location = new Point(204, 3);
            cardAvailableSpace.Name = "cardAvailableSpace";
            cardAvailableSpace.Size = new Size(185, 118);
            cardAvailableSpace.TabIndex = 1;
            // 
            // cardExitGateway
            // 
            cardExitGateway.CardDescription = "";
            cardExitGateway.CardIcon = Properties.Resources.icon_exit_card;
            cardExitGateway.CardTitle = "Exit Gateway";
            cardExitGateway.CardValue = "-";
            cardExitGateway.Dock = DockStyle.Fill;
            cardExitGateway.Location = new Point(405, 3);
            cardExitGateway.Name = "cardExitGateway";
            cardExitGateway.Size = new Size(185, 118);
            cardExitGateway.TabIndex = 2;
            // 
            // cardFineReport
            // 
            cardFineReport.CardDescription = "";
            cardFineReport.CardIcon = Properties.Resources.icon_fine_card;
            cardFineReport.CardTitle = "Fine Report";
            cardFineReport.CardValue = "-";
            cardFineReport.Dock = DockStyle.Fill;
            cardFineReport.Location = new Point(606, 3);
            cardFineReport.Name = "cardFineReport";
            cardFineReport.Size = new Size(185, 118);
            cardFineReport.TabIndex = 3;
            // 
            // DashboardAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 520);
            Controls.Add(tblContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAnalytics";
            Text = "DashboardAnalytics";
            tblTitle.ResumeLayout(false);
            tblTitle.PerformLayout();
            tblContent.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblCardWrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblTitle;
        private Label lblTitle;
        private Label lblDescription;
        private TableLayoutPanel tblContent;
        private TableLayoutPanel tblHeader;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTimeFrequency;
        private TableLayoutPanel tblCardWrapper;
        private UserControls.UCDashboardCard cardTotalRevenue;
        private UserControls.UCDashboardCard cardAvailableSpace;
        private UserControls.UCDashboardCard cardExitGateway;
        private UserControls.UCDashboardCard cardFineReport;
        private Guna.Charts.WinForms.GunaChart chartDashboard;
        private Guna.Charts.WinForms.GunaSplineDataset dataRevenue;
        private Guna.Charts.WinForms.GunaSplineDataset dataVehicle;
    }
}