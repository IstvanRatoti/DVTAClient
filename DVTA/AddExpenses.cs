using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DVTA
{
    public partial class addExpenses : Form
    {
        public addExpenses()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String date = textDate.Text.Trim();
            String item = textItem.Text.Trim();
            String price = textPrice.Text.Trim();
            DateTime now = DateTime.Now;
            String time = now.ToString("T");
    
            if (date== string.Empty || item == string.Empty ||price== string.Empty || time == string.Empty)
            {
                MessageBox.Show("Please enter all the fields!");
                return;
            }
            else
            {
                // Add a new item to the XML Document.
                XmlElement newItem = Main.userData.CreateElement("item");
                XmlElement newItemName = Main.userData.CreateElement("name");
                newItemName.InnerText = item;
                newItem.AppendChild(newItemName);
                XmlElement newItemPrice = Main.userData.CreateElement("price");
                newItemPrice.InnerText = price;
                newItem.AppendChild(newItemPrice);
                XmlElement newItemDate = Main.userData.CreateElement("date");
                newItemDate.InnerText = date;
                newItem.AppendChild(newItemDate);
                XmlElement newItemTime = Main.userData.CreateElement("time");
                newItemTime.InnerText = time;
                newItem.AppendChild(newItemTime);

                Main.userData.DocumentElement.AppendChild(newItem);
                this.Close();
            }
        }
       
        public  string Dat { get; set; }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

