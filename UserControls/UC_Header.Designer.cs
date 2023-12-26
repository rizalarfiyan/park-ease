namespace ParkEase.UserControls
{
    partial class UC_Header
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
            label3 = new Label();
            label2 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ubuntu", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(624, 12);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 10;
            label3.Text = "Admin";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 254, 234);
            label2.Font = new Font("Ubuntu", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(226, 139, 0);
            label2.Location = new Point(648, 35);
            label2.Name = "label2";
            label2.Size = new Size(37, 18);
            label2.TabIndex = 9;
            label2.Text = "Role";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.Transparent;
            guna2Button1.DisabledState.CustomBorderColor = Color.Transparent;
            guna2Button1.DisabledState.FillColor = Color.Transparent;
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.CustomBorderColor = Color.Transparent;
            guna2Button1.HoverState.FillColor = Color.Transparent;
            guna2Button1.HoverState.Image = Properties.Resources.icon_key;
            guna2Button1.Image = Properties.Resources.icon_key;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(773, 15);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(40, 40);
            guna2Button1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(226, 139, 0);
            label1.Font = new Font("Ubuntu", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(700, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 10, 5, 10);
            label1.Size = new Size(59, 52);
            label1.TabIndex = 14;
            label1.Text = "AA";
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 8;
            guna2Elipse2.TargetControl = label1;
            // 
            // UC_Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Name = "UC_Header";
            Size = new Size(831, 71);
            Load += UC_Header_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
