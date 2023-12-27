namespace ParkEase.View
{
    partial class TableUsers
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            lvwTable = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitle = new Label();
            lblDescription = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnPrev = new Guna.UI2.WinForms.Guna2Button();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            columnNo = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnUsername = new DataGridViewTextBoxColumn();
            columnRole = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewTextBoxColumn();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvwTable).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 3);
            tableLayoutPanel2.Controls.Add(lvwTable, 0, 5);
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(lblDescription, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.Size = new Size(914, 473);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAdd, 1, 0);
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 190);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(908, 67);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.BorderRadius = 8;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(226, 139, 0);
            btnAdd.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.icon_plus;
            btnAdd.Location = new Point(780, 3);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(128, 61);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.TextOffset = new Point(0, -2);
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Animated = true;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderColor = Color.FromArgb(255, 244, 133);
            txtSearch.BorderRadius = 8;
            txtSearch.BorderThickness = 2;
            txtSearch.Cursor = Cursors.Hand;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FillColor = Color.FromArgb(255, 249, 197);
            txtSearch.FocusedState.BorderColor = Color.Transparent;
            txtSearch.FocusedState.ForeColor = Color.FromArgb(226, 139, 0);
            txtSearch.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(226, 139, 0);
            txtSearch.HoverState.BorderColor = Color.Transparent;
            txtSearch.IconLeft = Properties.Resources.icon_search;
            txtSearch.IconLeftOffset = new Point(10, 0);
            txtSearch.IconRightOffset = new Point(10, 0);
            txtSearch.Location = new Point(0, 3);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.FromArgb(226, 139, 0);
            txtSearch.PlaceholderText = "Search";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(261, 61);
            txtSearch.TabIndex = 1;
            txtSearch.TextOffset = new Point(10, -2);
            // 
            // lvwTable
            // 
            lvwTable.AllowUserToAddRows = false;
            lvwTable.AllowUserToDeleteRows = false;
            lvwTable.AllowUserToResizeColumns = false;
            lvwTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            lvwTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            lvwTable.BackgroundColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(226, 139, 0);
            dataGridViewCellStyle2.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(226, 139, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            lvwTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            lvwTable.ColumnHeadersHeight = 40;
            lvwTable.Columns.AddRange(new DataGridViewColumn[] { columnNo, columnName, columnUsername, columnRole, columnStatus });
            lvwTable.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 254, 234);
            dataGridViewCellStyle3.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 98, 2);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            lvwTable.DefaultCellStyle = dataGridViewCellStyle3;
            lvwTable.Dock = DockStyle.Fill;
            lvwTable.GridColor = Color.FromArgb(255, 249, 197);
            lvwTable.Location = new Point(3, 304);
            lvwTable.Name = "lvwTable";
            lvwTable.ReadOnly = true;
            lvwTable.RowHeadersVisible = false;
            lvwTable.RowHeadersWidth = 51;
            lvwTable.RowTemplate.Height = 40;
            lvwTable.Size = new Size(908, 51);
            lvwTable.TabIndex = 15;
            lvwTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            lvwTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            lvwTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            lvwTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            lvwTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            lvwTable.ThemeStyle.BackColor = Color.FromArgb(255, 254, 234);
            lvwTable.ThemeStyle.GridColor = Color.FromArgb(255, 249, 197);
            lvwTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(226, 139, 0);
            lvwTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            lvwTable.ThemeStyle.HeaderStyle.Font = new Font("Ubuntu", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lvwTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            lvwTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            lvwTable.ThemeStyle.HeaderStyle.Height = 40;
            lvwTable.ThemeStyle.ReadOnly = true;
            lvwTable.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 254, 234);
            lvwTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lvwTable.ThemeStyle.RowsStyle.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lvwTable.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlDarkDark;
            lvwTable.ThemeStyle.RowsStyle.Height = 40;
            lvwTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            lvwTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Ubuntu", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(3, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 52);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "USERS";
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
            lblDescription.Location = new Point(3, 100);
            lblDescription.MaximumSize = new Size(549, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(504, 38);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "You are registered as a user at Park Ease, obey the rules and conditions. \r\nSafe and comfortable greetings.";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnPrev, 0, 0);
            tableLayoutPanel3.Controls.Add(btnNext, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 402);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(907, 67);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Right;
            btnPrev.BorderRadius = 8;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.CustomizableEdges = customizableEdges5;
            btnPrev.DisabledState.BorderColor = Color.DarkGray;
            btnPrev.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrev.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrev.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrev.FillColor = Color.FromArgb(226, 139, 0);
            btnPrev.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(314, 3);
            btnPrev.Margin = new Padding(0);
            btnPrev.Name = "btnPrev";
            btnPrev.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPrev.Size = new Size(128, 61);
            btnPrev.TabIndex = 19;
            btnPrev.Text = "Prev";
            btnPrev.TextOffset = new Point(0, -2);
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Left;
            btnNext.BorderRadius = 8;
            btnNext.Cursor = Cursors.Hand;
            btnNext.CustomizableEdges = customizableEdges7;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.FillColor = Color.FromArgb(226, 139, 0);
            btnNext.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(465, 3);
            btnNext.Margin = new Padding(0);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNext.Size = new Size(128, 61);
            btnNext.TabIndex = 18;
            btnNext.Text = "Next";
            btnNext.TextOffset = new Point(0, -2);
            // 
            // columnNo
            // 
            columnNo.HeaderText = "No.";
            columnNo.MinimumWidth = 6;
            columnNo.Name = "columnNo";
            columnNo.ReadOnly = true;
            columnNo.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnName
            // 
            columnName.HeaderText = "Name";
            columnName.MinimumWidth = 6;
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            columnName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnUsername
            // 
            columnUsername.HeaderText = "Username";
            columnUsername.MinimumWidth = 6;
            columnUsername.Name = "columnUsername";
            columnUsername.ReadOnly = true;
            columnUsername.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnRole
            // 
            columnRole.HeaderText = "Role";
            columnRole.MinimumWidth = 6;
            columnRole.Name = "columnRole";
            columnRole.ReadOnly = true;
            columnRole.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // columnStatus
            // 
            columnStatus.HeaderText = "Status";
            columnStatus.MinimumWidth = 6;
            columnStatus.Name = "columnStatus";
            columnStatus.ReadOnly = true;
            columnStatus.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TableUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 473);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableUsers";
            Text = "TableUsers";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lvwTable).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView lvwTable;
        private Label lblTitle;
        private Label lblDescription;
        private TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private DataGridViewTextBoxColumn columnNo;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnUsername;
        private DataGridViewTextBoxColumn columnRole;
        private DataGridViewTextBoxColumn columnStatus;
    }
}