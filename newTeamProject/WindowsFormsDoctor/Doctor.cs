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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            Mode.ChangeBackground(this.Controls);
            textBox_docEntry.Visible = false;
            button_docEntryClose.Visible = false;
        }



        private void pictureBox_docMessages_Click(object sender, EventArgs e)
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

        private void buttonSelect_docworking_Click(object sender, EventArgs e)
        {
            textBox_docEntry.Visible = true;
            //textBox_docEntry.Text = sql-დან
            button_docEntryClose.Visible = true;
            buttonSelect_docworking.Visible = false;
        }

        private void button_docEntryClose_Click(object sender, EventArgs e)
        {
            textBox_docEntry.Visible = false;
            button_docEntryClose.Visible = false;
            buttonSelect_docworking.Visible = true;
        }
    }
}
