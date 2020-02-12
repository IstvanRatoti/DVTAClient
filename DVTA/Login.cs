using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using ClientDataHandling;
using System.Xml;

namespace DVTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Remove this if debugging.
            //this.CheckCert();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // TODO Server address and port should be in the config files.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtLgnUsername.Text.Trim();
            String password = txtLgnPass.Text.Trim();
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }

            bool isLoggedIn = false;
            bool isLoggedinOnline = false;

            // Check if we can log in to the server.
            try
            {
                isLoggedinOnline = ClientConnect.Login(Main.serverAddress, Main.serverPort, username, password, ref Main.users);
            }
            catch(System.Net.Sockets.SocketException ex1)    // Try offline auth, if it did not work.
            {
                try
                {
                    Main.users.Load("users.xml");
                    
                    // Ok, I'm new to this, so here is what it is...
                    // users.DocumentElement is the xml data. LastChild is the users node (basically this: <users></users>).
                    foreach (XmlNode user in Main.users.DocumentElement.LastChild)
                    {
                        // Check for the username first...
                        // It will be the third child node in the xml.
                        if (username != user.ChildNodes[2].InnerText)
                        {
                            continue;   // Move on to the next user in case of a mismatch.
                        }

                        // For each user, the hash is the last. Innertext just gets that value.
                        // If the hash stored is equal to the hash of our pass, we successfully authenticated.
                        if (user.LastChild.InnerText == Crypto.HashPassword(password))
                        {
                            isLoggedIn = true;
                            if("1" == user.ChildNodes[1].InnerText)
                            {
                                Main.isAdmin = true;
                            }
                            break;
                        }
                    }
                }
                catch (System.IO.FileNotFoundException ex2)
                {
                    MessageBox.Show("Authentication failed!");
                    return;
                }
            }

            // If we could log in to the server, download everything.
            if(isLoggedinOnline)
            {
                isLoggedIn = true;
                Main.users.Save("users.xml");
                Main.userData = ClientConnect.DownloadUserXML(Main.serverAddress, Main.serverPort, username);
            }

            // Start the Main form.
            if(isLoggedIn)
            {
                Main.loggedInUser = username;
                // Check if the user is admin.
                foreach (XmlNode user in Main.users.DocumentElement.LastChild)
                {
                    if (username != user.ChildNodes[2].InnerText){ continue; }

                    if ("1" == user.ChildNodes[1].InnerText){ Main.isAdmin = true; break; }
                }
                // Check for the user's data locally.
                if (!isLoggedinOnline)
                {
                    try
                    {
                        Main.userData.Load(username + ".xml");
                    }
                    catch (System.IO.FileNotFoundException nofileex)
                    {
                        // TODO I dont like this. This path should just create the xml in memory, and not require any template files.
                        Main.userData.Load("template.xml");
                    }
                }

                this.Close();           // Maybe hide, and return after we exit the main form?
                Main main = new Main();
                main.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlgnregister(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            Application.Exit();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckCert()
        {
            CheckforDebuggers();
            ServicePointManager.ServerCertificateValidationCallback = PinPublicKey;

            try
            {
                WebRequest wr = WebRequest.Create("https://time.is/Unix_time_nows");
                WebResponse timeResp = wr.GetResponse();
                if (timeResp.ContentLength == 143) { return; }
                timeResp.Close();
            }
            catch (System.Net.WebException wex) { }

            this.btnregister.Enabled = false;
            this.btnlogin.Enabled = false;
        }

        private static String PUB_KEY = "3082010A0282010100B9A66237F88CC35C385712F002B469704B007A624A9862289926361D46524B589FD5B198BE557D48ECE7EAAC270531B5072030BC04698CE560B84C6E51FE2000EA5FC605D89F6E2C11581B416DCB3B71DE1B1526ABE48B342469C618E9BDA5E68A50655AC96B05E35B1955A3DB9ADF48F32A9F55B836B8EA89BB818094B2B549A5DD37C7F6CA879E0C40EB64F6E5F4B5152169BFD068EF488A5611BD9E37FB15CC2741F1D6F719567775F3333EFCBB9B659E9033FDE01C2B32543EF7E072897FA7CF79EBBEBA9C005A1F0DAD0F7CD7F025FBA3782FD34FF362B97868273F2A9E05CE4AF872DFAEE6F40A83F76348DAC54F710C82B5DFC2141AC2DDABECF1361D0203010001";

        public static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain,
                                SslPolicyErrors sslPolicyErrors)
        {
            if (null == certificate)
                return false;

            String pk = certificate.GetPublicKeyString();
            if (pk.Equals(PUB_KEY))
            {
                return true;
            }

            // Bad dog
            return false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckforDebuggers()
        {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    // System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);
                }
        }

    }
}
