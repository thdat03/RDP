using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RDP
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTextMessage();
        }

        private void txtMessenger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ChatForm()
        {
            InitializeComponent();
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Hủy bỏ sự kiện đóng form con
            Hide(); // Ẩn form con thay vì đóng nó
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn không cho ký tự Enter được hiển thị trong TextBox
                DisplayTextMessage(); // Gửi tin nhắn khi nhấn phím Enter
            }
        }

        private void DisplayTextMessage()
        {
            string text = txtInput.Text;
            text = text + "\n";
            txtMessenger.Items.Add(text);
            txtInput.Clear();
        }
    }
}
