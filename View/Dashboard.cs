﻿using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class frmDashboard : Form
    {
        private Form? activeForm = null;

        public frmDashboard()
        {
            InitializeComponent();
            this.Text = $"{App.APP_NAME} - Dashboard";
            InitializeHeader();
            InitializeRole();
        }

        private void InitializeHeader()
        {
            ucHeader.SetAvatar(Program.UserData?.Name ?? "Paijo Royo");
            ucHeader.SetUsername(Program.UserData?.Username ?? "username");
            ucHeader.SetRole(Program.UserData?.Role ?? "karyawan");
        }

        private void InitializeRole()
        {
            //if (Program.UserData?.Role != "admin")
            //{
            //    btnUsers.Hide();
            //    btnLocation.Hide();
            //    btnVehicleType.Hide();
            //    btnSettings.Hide();
            //}
        }

        private void MoveImageBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            imgSlide.Location = new Point(btn.Location.X + 58, btn.Location.Y - 22);
            imgSlide.SendToBack();
        }

        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageBox(sender);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            openChildForm(new TableVehicleType());
        }
    }
}
