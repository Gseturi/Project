using System.Windows.Forms;
using System;
using DocumentFormat.OpenXml.Drawing;
using System.Drawing;
using System.Xml;
namespace WindowsFormsDoctor
{

    public static class Mode
    {
        static XmlDocument YourInfo=new XmlDocument();
        public static bool Light = true;


        public static void SwitchMode()
        {
            
            YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
            
           

            if (Light == true)
            {
                Light = false;

            }
            else if (Light == false)
            {
                Light = true;
            }
            YourInfo.SelectSingleNode("User/BackGround").InnerText = Light.ToString();
            YourInfo.Save("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
        }
        public static void ChangeBackground(Control.ControlCollection container)
        {
            bool temp = true; 
            YourInfo.Load("C://Users//User//OneDrive//Desktop//Project//newTeamProject//WindowsFormsDoctor//YourInfo.xml");
            if (YourInfo.SelectSingleNode("User/BackGround").InnerText=="True")
            {
                temp = true;
            }else if (YourInfo.SelectSingleNode("User/BackGround").InnerText=="False")
            {
                temp = false;
            }
            foreach (Control component in container)
            {

                if (temp == false)
                {
                    if (component is Panel)
                    {
                        component.BackColor = Color.White;
                        component.BackColor = ControlPaint.Dark(component.BackColor);
                 
                    }
                    else if (component is Button)
                    {
                        component.BackColor = Color.White;
                        component.BackColor = ControlPaint.Dark(component.BackColor);
                   
                    }
                    else if (component is TextBox)
                    {
                        component.BackColor = Color.White;
                        component.BackColor = ControlPaint.Dark(component.BackColor);
                
                    }
                }
                if (temp == true)
                {
                    if (component is Panel)
                    {


                        component.BackColor = Color.White;
                
                    }
                    else if (component is Button)
                    {
                        component.BackColor = Color.White;
              
                    }
                    else if (component is TextBox)
                    {
                        component.BackColor = Color.White;
                     

                    }
                }

            }
        }
       
    }
}
