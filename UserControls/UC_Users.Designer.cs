namespace ParkEase.UserControls
{
    partial class UC_Users
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblDesUsers = new Label();
            lblUsers = new Label();
            tableUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tableLayoutPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableUsers).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(guna2Panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(guna2Panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.68072F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.3192749F));
            tableLayoutPanel1.Size = new Size(831, 664);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblDesUsers);
            guna2Panel1.Controls.Add(lblUsers);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(825, 210);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(tableUsers);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.Location = new Point(3, 219);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(825, 442);
            guna2Panel2.TabIndex = 0;
            // 
            // lblDesUsers
            // 
            lblDesUsers.Anchor = AnchorStyles.None;
            lblDesUsers.AutoSize = true;
            lblDesUsers.BackColor = Color.FromArgb(255, 254, 234);
            lblDesUsers.Font = new Font("Ubuntu", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesUsers.ForeColor = SystemColors.ControlDarkDark;
            lblDesUsers.Location = new Point(27, 124);
            lblDesUsers.Name = "lblDesUsers";
            lblDesUsers.Size = new Size(377, 32);
            lblDesUsers.TabIndex = 8;
            lblDesUsers.Text = "Welcome to Park Ease, an application that makes it easier for you \r\nto manage parking safely and comfortably.";
            lblDesUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.None;
            lblUsers.AutoSize = true;
            lblUsers.BackColor = Color.Transparent;
            lblUsers.Font = new Font("Ubuntu", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsers.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsers.Location = new Point(27, 61);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(153, 27);
            lblUsers.TabIndex = 7;
            lblUsers.Text = "TABLE USERS";
            lblUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableUsers
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            tableUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            tableUsers.BackgroundColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(226, 139, 0);
            dataGridViewCellStyle5.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            tableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle6.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tableUsers.DefaultCellStyle = dataGridViewCellStyle6;
            tableUsers.GridColor = SystemColors.ControlDark;
            tableUsers.Location = new Point(27, 3);
            tableUsers.Name = "tableUsers";
            tableUsers.RowHeadersVisible = false;
            tableUsers.RowHeadersWidth = 51;
            tableUsers.RowTemplate.Height = 29;
            tableUsers.Size = new Size(772, 417);
            tableUsers.TabIndex = 0;
            tableUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tableUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            tableUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tableUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tableUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tableUsers.ThemeStyle.BackColor = Color.FromArgb(255, 254, 234);
            tableUsers.ThemeStyle.GridColor = SystemColors.ControlDark;
            tableUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(226, 139, 0);
            tableUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tableUsers.ThemeStyle.HeaderStyle.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            tableUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tableUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUsers.ThemeStyle.HeaderStyle.Height = 22;
            tableUsers.ThemeStyle.ReadOnly = false;
            tableUsers.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 254, 234);
            tableUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableUsers.ThemeStyle.RowsStyle.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            tableUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tableUsers.ThemeStyle.RowsStyle.Height = 29;
            tableUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tableUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Username";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Role";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 8;
            guna2Elipse1.TargetControl = tableUsers;
            // 
            // UC_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 234);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Users";
            Size = new Size(831, 664);
            tableLayoutPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblDesUsers;
        private Label lblUsers;
        private Guna.UI2.WinForms.Guna2DataGridView tableUsers;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
