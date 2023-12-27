namespace ParkEase.UserControls
{
    partial class UC_TopBar
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
            panel1 = new Panel();
            Close = new PictureBox();
            Maximize = new PictureBox();
            Minimize = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(226, 139, 0);
            panel1.Controls.Add(Close);
            panel1.Controls.Add(Maximize);
            panel1.Controls.Add(Minimize);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 34);
            panel1.TabIndex = 0;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.Image = Properties.Resources.icon_close;
            Close.Location = new Point(890, 8);
            Close.Margin = new Padding(3, 2, 3, 2);
            Close.Name = "Close";
            Close.Size = new Size(22, 19);
            Close.SizeMode = PictureBoxSizeMode.StretchImage;
            Close.TabIndex = 5;
            Close.TabStop = false;
            Close.Click += Close_Click;
            // 
            // Maximize
            // 
            Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximize.Image = Properties.Resources.icon_maximize;
            Maximize.Location = new Point(856, 8);
            Maximize.Margin = new Padding(3, 2, 3, 2);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(22, 19);
            Maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            Maximize.TabIndex = 5;
            Maximize.TabStop = false;
            Maximize.Click += Maximize_Click;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.Image = Properties.Resources.icon_minimize;
            Minimize.Location = new Point(822, 8);
            Minimize.Margin = new Padding(3, 2, 3, 2);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(22, 19);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 5;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 25;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_TopBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_TopBar";
            Size = new Size(922, 34);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Minimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox Close;
        private PictureBox Maximize;
        public Panel panel1;
    }
}
