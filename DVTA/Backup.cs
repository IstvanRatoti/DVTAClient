using ClientDataHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVTA
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ClientConnect.BackupFiles(Main.serverAddress, Main.serverPort, Main.clientHash));
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Could not connect to the server!", "Error!");
            }
        }
    }
}
