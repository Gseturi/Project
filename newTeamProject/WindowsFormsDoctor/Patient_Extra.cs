using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exampleproject;
using System.Xml;
namespace WindowsFormsDoctor
{
    public partial class Patient_Extra : Form
    {
        XmlDocument YourInfo=new XmlDocument();
        public Patient_Extra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add();
           
        }
        private void add()
        {

            DataTable x = new DataTable();
            x = SqlCom.CreateInt();
            YourInfo = new XmlDocument();
            DataRow[] temp = x.Select();
            string y = temp[0][0].ToString();
            YourInfo = new XmlDocument();
            YourInfo.Load("../../YourInfo.xml");
            string xs = y + "," + YourInfo.SelectSingleNode("User/rooms").InnerText;
            YourInfo.SelectSingleNode("User/rooms").InnerText = xs;
            YourInfo.Save("../../YourInfo.xml");
            SqlCom.SendMessege(int.Parse(y), RegStatusBox.SelectedItem.ToString(),"Help", richTextBox2.Text);
        }
        
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
