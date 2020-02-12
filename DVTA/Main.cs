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
using System.Data.SqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary;
using ClientDataHandling;
using System.Xml;

namespace DVTA
{
    public partial class Main : Form
    {
        // These will hold the crucial data in memory.
        public static XmlDocument users = new XmlDocument();
        public static XmlDocument userData = new XmlDocument();
        public static string clientHash = "";
        public static bool isAdmin = false;
        public static string loggedInUser = "";
        public static string serverAddress = ConfigurationManager.AppSettings["SERVERADDRESS"].ToString();
        public static int serverPort = Int32.Parse(ConfigurationManager.AppSettings["SERVERPORT"].ToString());

        public Main()
        {
            InitializeComponent();
            if ("" == Main.loggedInUser)
            {
                this.Hide();
                Login lgn = new Login();
                lgn.ShowDialog();
                this.Close();
                Application.Exit();
            }

            if(isAdmin)
            {
                this.AdminToolsLabel.Visible = true;
                this.AdminToolsLabel.Enabled = true;

                this.btnTestDBConn.Visible = true;
                this.btnTestDBConn.Enabled = true;
                this.btnBackupFiles.Visible = true;
                this.btnBackupFiles.Enabled = true;
                this.btnCheckLogs.Visible = true;
                this.btnCheckLogs.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Upload and save the changes in the XML before logging out.
            try
            {
                ClientConnect.UploadUserXML(serverAddress, serverPort, userData, loggedInUser);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Could not connect to the server!\nThe changes will only be saved locally!", "Error!");
            }
            userData.Save(loggedInUser + ".xml");

            this.Close();
            //Login lgn = new Login();
            //lgn.ShowDialog();

            return;
        }

        private void userLoggedIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Show the logged in user's name and email address. FLAG 4!
            try
            {
                MessageBox.Show("Username: " + loggedInUser + "\n" + "Email ID: " + ClientConnect.ViewProfile(serverAddress, serverPort, loggedInUser));
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Could not connect to the server!", "Error!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addExpenses add = new addExpenses();
            add.ShowDialog();

            DataSet expenseSet = new DataSet();
            expenseSet.ReadXml(new XmlNodeReader(Main.userData));

            dataGridView1.DataSource = expenseSet.Tables["item"];
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // This is funky again...DataTables dont like the format, so I have to use DataSets first...
            DataSet expenseSet = new DataSet();
            expenseSet.ReadXml(new XmlNodeReader(Main.userData));

            dataGridView1.DataSource = expenseSet.Tables["item"];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to clear all your expenses?", "Caution", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Main.userData.DocumentElement.RemoveAll();
            }

            DataSet expenseSet = new DataSet();
            expenseSet.ReadXml(new XmlNodeReader(Main.userData));

            dataGridView1.DataSource = expenseSet.Tables["item"];
        }

        private void btnTestDBConn_Click(object sender, EventArgs e)
        {
            TestDB testDB = new TestDB();
            testDB.ShowDialog();

            /*try
            {
                MessageBox.Show("You can find the admin client on the webserver:\n"
                + ClientConnect.DownloadAdminClient(serverAddress, serverPort, Main.users.DocumentElement.FirstChild.InnerText)
                + "\nAlso...STOP LOSING THE GODDAM ADMIN CLIENT, KEVIN!");
            }
            catch (System.Net.Sockets.SocketException socex)
            {
                MessageBox.Show("Could not connect to the server!", "Error!");
            }*/
        }

        private void btnBackupFiles_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void btnCheckLogs_Click(object sender, EventArgs e)
        {
            string instruction = "FIXME";

            try
            {
                MessageBox.Show(ClientConnect.CheckLogs(serverAddress, serverPort, Main.clientHash, instruction));
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Could not connect to the server!", "Error!");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
