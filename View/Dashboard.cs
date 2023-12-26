﻿using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using ParkEase.Constants;

namespace ParkEase.View
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Text = $"{App.APP_NAME} - Dashboard";
            InitializeHeader();
        }

        private void InitializeHeader()
        {
            ucHeader.SetAvatar(Program.UserData?.Name ?? "AZ");
            ucHeader.SetUsername(Program.UserData?.Username ?? "username");
            ucHeader.SetRole(Program.UserData?.Role ?? "admin");
        }

        private void MoveImageBox(object sender)
        {
            Guna2Button btn = (Guna2Button)sender;
            imgSlide.Location = new Point(btn.Location.X + 33, btn.Location.Y - 22);
            imgSlide.SendToBack();
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageBox(sender);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
