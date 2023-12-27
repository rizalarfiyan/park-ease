namespace ParkEase.UserControls
{
    partial class UC_TableVehicleType
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Search = new PictureBox();
            tableVehicleType = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableVehicleType).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Ubuntu", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(364, 32);
            label2.TabIndex = 10;
            label2.Text = "Choose your vehicle type at Park Ease, according to the type of \r\nvehicle you park. Safe and comfortable greetings.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Ubuntu", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(232, 27);
            label1.TabIndex = 9;
            label1.Text = "TABLE VEHICLE TYPE";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.None;
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderColor = Color.FromArgb(255, 249, 197);
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.BorderThickness = 3;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(255, 249, 197);
            guna2TextBox1.FocusedState.BorderColor = Color.Transparent;
            guna2TextBox1.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            guna2TextBox1.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.FromArgb(226, 139, 0);
            guna2TextBox1.HoverState.BorderColor = Color.Transparent;
            guna2TextBox1.IconLeftOffset = new Point(10, 0);
            guna2TextBox1.IconRightOffset = new Point(10, 0);
            guna2TextBox1.Location = new Point(452, 80);
            guna2TextBox1.Margin = new Padding(6, 7, 6, 7);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            guna2TextBox1.PlaceholderText = " ";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(323, 45);
            guna2TextBox1.TabIndex = 13;
            guna2TextBox1.TextOffset = new Point(20, 0);
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search.BackColor = Color.FromArgb(255, 249, 197);
            Search.Image = Properties.Resources.icon_search;
            Search.Location = new Point(730, 91);
            Search.Name = "Search";
            Search.Size = new Size(25, 25);
            Search.SizeMode = PictureBoxSizeMode.StretchImage;
            Search.TabIndex = 14;
            Search.TabStop = false;
            // 
            // tableVehicleType
            // 
            tableVehicleType.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            tableVehicleType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableVehicleType.BackgroundColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(226, 139, 0);
            dataGridViewCellStyle2.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tableVehicleType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableVehicleType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableVehicleType.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle3.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableVehicleType.DefaultCellStyle = dataGridViewCellStyle3;
            tableVehicleType.GridColor = Color.FromArgb(255, 249, 197);
            tableVehicleType.Location = new Point(35, 180);
            tableVehicleType.Name = "tableVehicleType";
            tableVehicleType.RowHeadersVisible = false;
            tableVehicleType.RowHeadersWidth = 51;
            tableVehicleType.RowTemplate.Height = 29;
            tableVehicleType.Size = new Size(740, 437);
            tableVehicleType.TabIndex = 15;
            tableVehicleType.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tableVehicleType.ThemeStyle.AlternatingRowsStyle.Font = null;
            tableVehicleType.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tableVehicleType.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tableVehicleType.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tableVehicleType.ThemeStyle.BackColor = Color.FromArgb(255, 254, 234);
            tableVehicleType.ThemeStyle.GridColor = Color.FromArgb(255, 249, 197);
            tableVehicleType.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(226, 139, 0);
            tableVehicleType.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tableVehicleType.ThemeStyle.HeaderStyle.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            tableVehicleType.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tableVehicleType.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableVehicleType.ThemeStyle.HeaderStyle.Height = 22;
            tableVehicleType.ThemeStyle.ReadOnly = false;
            tableVehicleType.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 254, 234);
            tableVehicleType.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableVehicleType.ThemeStyle.RowsStyle.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tableVehicleType.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlDarkDark;
            tableVehicleType.ThemeStyle.RowsStyle.Height = 29;
            tableVehicleType.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tableVehicleType.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Code";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 8;
            guna2Elipse1.TargetControl = tableVehicleType;
            // 
            // UC_TableVehicleType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableVehicleType);
            Controls.Add(Search);
            Controls.Add(guna2TextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_TableVehicleType";
            Size = new Size(831, 664);
            ((System.ComponentModel.ISupportInitialize)Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableVehicleType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private PictureBox Search;
        private Guna.UI2.WinForms.Guna2DataGridView tableVehicleType;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
