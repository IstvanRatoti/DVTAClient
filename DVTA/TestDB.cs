using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using ClientDataHandling;

namespace DVTA
{
    public partial class TestDB : Form
    {
        public TestDB()
        {
            InitializeComponent();
        }


        private void TestDB_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ClientConnect.TestDBConnection(Main.serverAddress, Main.serverPort, Main.clientHash, dbNameBox.Text));
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Could not connect to the server!", "Error!");
            }
        }
    }
}
