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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            //if (!Mode.Light) Mode.SwitchMode(?????);
            dataGridView_messagesGeneral.Visible = true;
            button_messagesSelect.Visible = true;
            button_messagesBack.Visible = false;
            pictureBox_messages.Visible = false;
            label_messagesName.Visible = false;
        }


        private void button_messagesBack_Click(object sender, EventArgs e)
        {
            dataGridView_messagesGeneral.Visible = true;
            button_messagesSelect.Visible = true;
            button_messagesBack.Visible = false;
            pictureBox_messages.Visible = false;
            label_messagesName.Visible = false;
        }
        private void button_messagesSelect_Click(object sender, EventArgs e)
        {
            dataGridView_messagesGeneral.Visible = false;
            button_messagesSelect.Visible = false;
            button_messagesBack.Visible = true;
            pictureBox_messages.Visible = true;
            label_messagesName.Visible = true;

            //კოდი, რომელიც სურათს და სახელს ჩასვამს (label & picturebox)
            //კოდი, რომ კონკრეტულ პიროვნებასთან მიმოწერა გამოიტანოს (ancor-ით ჩვენი მარჯვნივ დავამაგროთ, სხვისი - მარცხნივ)
        }

        private void pictureBox_messages_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.ShowDialog();
            this.Show();
        }
    }
}
