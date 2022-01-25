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
    public partial class Profile : Form
    {
        XmlDocument YourInfo;
        Control temp;
        public Profile()
        {   
            
            InitializeComponent();
            temp = this;
            Mode.ChangeBackground(temp.Controls);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            YourInfo = new XmlDocument();
            YourInfo.Load("../../YourInfo.xml");
            label_profileName.Text = YourInfo.SelectSingleNode("User/Username").InnerText;
            label_profileDialogNumb.Text = YourInfo.SelectSingleNode("User/Name").InnerText+" "+YourInfo.SelectSingleNode("User/LastName").InnerText;
            textBox_profile.Text = YourInfo.SelectSingleNode("User/Bio").InnerText;
            Mode.ChangeBackground(this.Controls);
        }

        private void button_profileSwitch_Click(object sender, EventArgs e)
        {
            Mode.SwitchMode();
            Mode.ChangeBackground(this.Controls);
        }
        private void GetAllObject()
        {

        }
        private void label_profileName_Click(object sender, EventArgs e)
        {

        }

        private void textBox_profile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
