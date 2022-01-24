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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            //if (!Mode.Light) Mode.SwitchMode(?????);
        }



        private void button_adminDownload_Click(object sender, EventArgs e)
        {
            //CV-ს გადმოწერის კოდი
        }

        private void pictureBox_adminMessages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            this.Hide();
            messages.ShowDialog();
            this.Show();
        }

        private void pictureBox_docIcon_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Hide();
            profile.ShowDialog();
            this.Show();
        }

        private void button_adminAdd_Click(object sender, EventArgs e)
        {
            //დაამატე sql-ში
        }
    }
}
