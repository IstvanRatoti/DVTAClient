using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClientDataHandling
{
    public class ClientConnect
    {
        // Connect to the server, and try to log in. The server will responde with the xml user list.
        // The return value is true, in case of a successful login and false otherwise.
        public static bool Login(string server, Int32 port, string username, string password, ref XmlDocument users, ref string clientHash)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] creds = Encoding.UTF8.GetBytes("login " + username + " " + password);
            byte[] response = new byte[65535];
            string responseString;

            // Send creds to the server.
            stream.Write(creds, 0, creds.Length);

            // Receive response.
            stream.Read(response, 0, response.Length);
            client.Close();
            responseString = Encoding.UTF8.GetString(response);

            // Login Failed.
            if (responseString == "InvalidCredentials" || responseString == "UnknownCommand")
            {
                users = null;
                return false;
            }

            // Creates the users xml IN MEMORY. The users object needs to exist!
            // This XML should contain a clientHash of some kind, which can be used to download a client. There should be different hashes for admin and regular clients.
            users.LoadXml(responseString);

            // Create the clientHash string in Main
            clientHash = users.DocumentElement.FirstChild.InnerText;

            return true;
        }

        // Register a new user. Return true on success, false otherwise.
        public static bool Register(string server, Int32 port, string username, string password, string email)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("regis " + username + " " + password + " " + email);
            byte[] response = new byte[256];
            string responseString;

            // Send new user's data.
            stream.Write(userData, 0, userData.Length);

            // Get server response.
            stream.Read(response, 0, response.Length);
            client.Close();
            responseString = Encoding.UTF8.GetString(response);

            // Catch success.
            if ("Success" == responseString)
            {
                return true;
            }

            // In any other case, assume failure.
            return false;
        }

        // Downloads a user's XML file, containing expenses and email address. Returns the XML document.
        public static XmlDocument DownloadUserXML(string server, Int32 port, string username)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("dlxml " + username);
            byte[] response = new byte[256];
            string responseString;

            // Send the username whose XML we want.
            stream.Write(userData, 0, userData.Length);

            // Get server response.
            stream.Read(response, 0, response.Length);
            client.Close();
            responseString = Encoding.UTF8.GetString(response);

            // On fail, return a null.
            if (responseString == "UnknownUser" || responseString == "UnknownCommand")
            {
                return null;
            }

            // Otherwise, create the xml document sent.
            XmlDocument userXML = new XmlDocument();
            userXML.LoadXml(responseString);
            return userXML;
        }

        // Send the User's XML to the server.
        // Maybe send back confirmation that the stuff was uploaded successfully?
        public static void UploadUserXML(string server, Int32 port, XmlDocument userXML, string username)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("ulxml " + username + " " + userXML.OuterXml);

            // Send the user's XML to the server.
            stream.Write(userData, 0, userData.Length);
            client.Close();
        }

        // Sends a username and then the server sends back the associated email address.
        // The email address should only be available from the server (not in any client side XML).
        public static string ViewProfile(string server, Int32 port, string username)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("vwprf " + username);
            byte[] response = new byte[256];

            // Send the username for the profile.
            stream.Write(userData, 0, userData.Length);

            // Get server response.
            stream.Read(response, 0, response.Length);
            client.Close();
            return Encoding.UTF8.GetString(response);
        }

        // Admin command. Tests the database connection on the server side.
        // Can inject xml inside, to hijack the login request.
        public static string TestDBConnection(string server, Int32 port, string clientHash, string DBName)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("tstdb " + clientHash + " " + DBName);
            byte[] response = new byte[short.MaxValue];

            stream.Write(userData, 0, userData.Length);

            stream.Read(response, 0, response.Length);
            client.Close();
            return Encoding.UTF8.GetString(response);
        }

        // Admin command. Backs up the flag (which should already be there...)
        public static string BackupFiles(string server, Int32 port, string clientHash, string username, string key)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("bckup " + clientHash + " " + username + " " + key);
            byte[] response = new byte[short.MaxValue];

            stream.Write(userData, 0, userData.Length);
            Console.WriteLine(Crypto.DecryptPassword("Testing", key));

            stream.Read(response, 0, response.Length);
            client.Close();
            return Encoding.UTF8.GetString(response);
        }

        public static string CheckLogs(string server, Int32 port, string clientHash, string instruction)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] userData = Encoding.UTF8.GetBytes("chklg " + clientHash + " " + instruction);
            byte[] response = new byte[short.MaxValue];

            stream.Write(userData, 0, userData.Length);

            stream.Read(response, 0, response.Length);
            client.Close();
            return Encoding.UTF8.GetString(response);
        }

        // This function will supply the admin with a "special" admin client. I might want to put this
        // on a webserver and send a link back...I could leave the server-side codes in the same directory...
        // Wont use this I think.
        public static string DownloadAdminClient(string server, Int32 port, string clientHash)
        {
            TcpClient client = new TcpClient(server, port);
            NetworkStream stream = client.GetStream();
            byte[] clientHashData = Encoding.UTF8.GetBytes("dladc " + clientHash);
            byte[] response = new byte[256];

            // Send the clientHash.
            stream.Write(clientHashData, 0, clientHashData.Length);

            // Get server response.
            stream.Read(response, 0, response.Length);
            client.Close();
            return Encoding.UTF8.GetString(response);
        }
    }
}
