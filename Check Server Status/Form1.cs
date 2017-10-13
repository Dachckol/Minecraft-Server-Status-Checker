using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Check_Server_Status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Server server = new Server();
        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient MinecraftServer = new TcpClient();
            try
            {
                server.setport(textBox2.Text);
                server.setip(textBox1.Text);
                MinecraftServer.Connect(server.getip(), server.getport());
                this.BackColor = Color.Green;
            }
            catch (Exception xce)
            {
                this.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(server);
            form2.Show();
            Runinfo stuff = new Runinfo();
        }
    }
}
