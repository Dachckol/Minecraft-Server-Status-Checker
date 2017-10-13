using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Check_Server_Status
{
    public partial class Form2 : Form
    {
        public Runinfo info = new Runinfo();
        public Server server = new Server();
        public Form2(Server server)
        {
            InitializeComponent();
            this.server = server;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                info.username = textBox1.Text;
                info.password = textBox2.Text;
            }
            else
            {
                openFileDialog1.ShowDialog();
                info.location = openFileDialog1.FileName;
                info.username = textBox1.Text;
                info.password = textBox2.Text;
            }
            System.Diagnostics.Process.Start(info.location, info.getfull() + " " + server.getfull());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            info.location = openFileDialog1.FileName;
            checkBox1.Checked = true;
        }
    }
}
