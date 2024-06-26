﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using AxMSTSCLib;
using RDPCOMAPILib;
using AxRDPCOMAPILib;
namespace RDP
{
    public partial class RemoteDesktop : Form
    {
        public static RDPSession currentSession = null;

        private bool isChatFormOpened = false;
        private Chat chatForm1;

        public static void createSession()
        {
            currentSession = new RDPSession();
        }

        public static void Connect(RDPSession session)
        {
            session.OnAttendeeConnected += Incoming;
            session.Open();
        }

        public static void Disconnect(RDPSession session)
        {
            session.Close();
        }

        public static string getConnectionString(RDPSession session, String authString,
            string group, string password, int clientLimit)
        {
            IRDPSRAPIInvitation invitation =
                session.Invitations.CreateInvitation
                (authString, group, password, clientLimit);
            return invitation.ConnectionString;
        }

        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }

        public RemoteDesktop()
        {
            InitializeComponent();
        }

        private void RemoteDesktop_Load(object sender, EventArgs e)
        {
            createSession();
            Connect(currentSession);
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isChatFormOpened = false; // Đặt lại giá trị của biến khi form Chat đã đóng
        }

        private bool isChatFormOpened1;

        private void OpenChildForm()
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                new ScreenShare(txtKey.Text).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect(currentSession);
        }

        private void txtClientIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYourIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdp_OnConnecting(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void KeyGen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_KeyGen_Click(object sender, EventArgs e)
        {
            KeyGen.Text = getConnectionString(currentSession, "test", "group", "", 5);
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
             if (isChatFormOpened)
            {
                MessageBox.Show("ChatServer form is already open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chatForm1 = new Chat();
            chatForm1.FormClosed += ChatForm_FormClosed; // Đăng ký sự kiện FormClosed
            chatForm1.Show();
            isChatFormOpened = true;
        }
    }
}
