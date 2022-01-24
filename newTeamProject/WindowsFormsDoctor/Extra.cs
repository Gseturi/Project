using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDoctor
{
    public partial class Extra : Form
    {
        public Extra()
        {   
            
            InitializeComponent();
            richTextBox2.Visible = false;
            Lable2.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
        }
       
        
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        public void Makeinvisible(bool x)
        {
            if (x==false)
            {
                richTextBox2.Visible = false ;
                Lable2.Visible=false;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else if(x==true)
            {
                
                    textBox1.Visible = true;
                    label1.Visible = true;
                    richTextBox2.Visible = true;
                    Lable2.Visible = true; 
                
            }
        } 
        public string Gettext(bool x)
        {
            if (x==true)
            {
                return richTextBox1.Text;
            }
            else if(x==false){

                return richTextBox2.Text;
            }
            return " ";
        }
        public string GetSp()
        {
            return textBox1.Text.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Extra_Load(object sender, EventArgs e)
        {
         
            Mode.ChangeBackground(this.Controls);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
