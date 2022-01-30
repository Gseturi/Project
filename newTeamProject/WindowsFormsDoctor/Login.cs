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
    public partial class Login : Form
        
    {
        static XmlDocument YourInfo;
        private string hold;
        private Extra ExtraInf;
        private Doctor Doctorform;
        private Patient Petientforml;
        public Login()
        {
            InitializeComponent();
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            YourInfo = new XmlDocument();
            ExtraInf = new Extra();
            // YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
            YourInfo.Load("../../YourInfo.xml");
            Mode.ChangeBackground(this.Controls);
            TEST();

        }
        public void TEST()
        {
           // SqlCom.SendMessege(123, "eee", "eee", "eee");
           string y= Encrypte.Decrypt("YE9kNjSPutI=");
          //  List<string> x= SqlCom.GetMessegesR(y);
        }
        private void RegFirstnameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (RegUsername.Text != null && RegLastnameBox.Text != null && RegUsername.Text != null && RegPassBox.SelectedText.ToString() != null && ExtraInf.Gettext(true)!=null) {
                if (RegStatusBox.SelectedItem.ToString() == "Doctor")
                {
                    if (RegConfirmPassBox.Text == RegPassBox.Text)
                    {
                        SqlCom.Register_Doctor(RegFirstnameBox.Text, RegLastnameBox.Text, RegUsername.Text, RegPassBox.Text, ExtraInf.GetSp() , ExtraInf.Gettext(false),ExtraInf.Gettext(true));
                        ExtraInf.Close();
                    }
                }
                if (RegStatusBox.SelectedItem.ToString() == "Patient")
                {
                    if (RegConfirmPassBox.Text == RegPassBox.Text) {
                        SqlCom.Register_Patient(RegFirstnameBox.Text, RegLastnameBox.Text, RegUsername.Text, RegPassBox.Text,ExtraInf.Gettext(false));
                        ExtraInf.Close(); 
                    }
                }
            }
        }

        private void RegStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RegStatusBox.SelectedItem.ToString() == "Doctor")
            {
                ExtraInf.Makeinvisible(true);


            }
            else
          if (RegStatusBox.SelectedItem.ToString() == "Patient")
            {
                ExtraInf.Makeinvisible(false);
            }
            ExtraInf.ShowDialog();
            
          
        }

        private void LogUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegLastnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegConfirmPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
           if( SqlCom.FechDoctor(LogUsernameBox.Text, LogPassBox.Text) != true)
            {
                var asd = SqlCom.GetInteraction(SqlCom.GetInteractionId());
              
               DataRow[] x = SqlCom.FechDoctorInfo(LogUsernameBox.Text, LogPassBox.Text).Select();

               RegConfirmPassBox.Text = x[0][1].ToString();
                XmlDocument YourInfo = new XmlDocument();
                // YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
                YourInfo.Load("../../YourInfo.xml");
                YourInfo.SelectSingleNode("User/Name").InnerText= x[0][0].ToString();
                YourInfo.SelectSingleNode("User/LastName").InnerText = x[0][1].ToString();
                YourInfo.SelectSingleNode("User/Username").InnerText = x[0][2].ToString();
                YourInfo.SelectSingleNode("User/PassWord").InnerText = x[0][3].ToString();
                YourInfo.SelectSingleNode("User/Id").InnerText = x[0][5].ToString();
                YourInfo.SelectSingleNode("User/Bio").InnerText = x[0][6].ToString();
                XmlNode desc = YourInfo.CreateElement("discription");
                XmlNode temp = YourInfo.CreateElement("YourPatients");
                XmlNode teemp = YourInfo.CreateElement("YourDoctors");
                XmlNode tempp = YourInfo.SelectSingleNode("User/YourDoctors");
                desc.InnerText = x[0][7].ToString();
                if (YourInfo.SelectSingleNode("User/discription")==null) {
                    YourInfo.SelectSingleNode("User").AppendChild(desc);
                }
                if (YourInfo.SelectSingleNode("User/YourDoctors") != null)
                {

                    YourInfo.DocumentElement.RemoveChild(tempp);
                }
                if (YourInfo.SelectSingleNode("User/YourPatients") == null)
                {

                    temp.InnerText = " ";
                    YourInfo.SelectSingleNode("User").AppendChild(temp);
                    

                }
                
                   YourInfo.SelectSingleNode("User/discription").InnerText = desc.InnerText;
                
                YourInfo.Save("../../YourInfo.xml");

                Doctorform = new Doctor();
                Doctorform.ShowDialog();
                this.Hide();
            }
           if(SqlCom.FechPatient(LogUsernameBox.Text, LogPassBox.Text) != true)
            {

                
               DataRow[] x= SqlCom.FechPatientInfo(LogUsernameBox.Text, LogPassBox.Text).Select();
                RegConfirmPassBox.Text = x.ToString();
                XmlDocument YourInfo = new XmlDocument();
                // YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
                YourInfo.Load("../../YourInfo.xml");
                YourInfo.SelectSingleNode("User/Name").InnerText = x[0][0].ToString();
                YourInfo.SelectSingleNode("User/LastName").InnerText = x[0][1].ToString();
                YourInfo.SelectSingleNode("User/Username").InnerText = x[0][2].ToString();
                YourInfo.SelectSingleNode("User/PassWord").InnerText = x[0][3].ToString();
                YourInfo.SelectSingleNode("User/Id").InnerText = x[0][4].ToString();
                YourInfo.SelectSingleNode("User/Bio").InnerText = x[0][5].ToString();
                XmlNode temp = YourInfo.CreateElement("YourDoctors");
                XmlNode desc = YourInfo.SelectSingleNode("User/discription");
                XmlNode tempp = YourInfo.SelectSingleNode("User/YourPatients");
                if (YourInfo.SelectSingleNode("User/discription") !=null) {
                    
                    YourInfo.DocumentElement.RemoveChild(desc);
                    
          

                }
                if (YourInfo.SelectSingleNode("User/YourPatients") != null)
                {
                    YourInfo.DocumentElement.RemoveChild(tempp);
                    YourInfo.SelectSingleNode("User").AppendChild(temp);
                }
                YourInfo.Save("../../YourInfo.xml");
                Petientforml = new Patient();
                Petientforml.ShowDialog();
                this.Hide();
            }
        }
    }
}
