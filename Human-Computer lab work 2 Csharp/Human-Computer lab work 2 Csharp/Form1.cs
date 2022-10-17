using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Computer_lab_work_2_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.ToString() == "A" || e.KeyCode.ToString() == "a")
            {
                menuItem7.Visible = true;
                menuItem8.Visible = true;
            }
            else if (e.KeyCode.ToString() == "C" || e.KeyCode.ToString() == "c")
            {
                menuItem7.Text = "Format";
                menuItem8.Text = "Format";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == true)
            {
                MessageBox.Show("In case you are facing any problem\n Please contact us using email or live chat and our team will help you.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The file word will be copied");
            if (pictureBox2.Enabled == true)
            {
            }

        }

        private void checkCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messageToolStripMenuItem.Enabled == true)
            {
                MessageBox.Show("This is my second project in the subject");
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void menuItem3_Click(object sender, EventArgs e)
        {
            if (menuItem3.RadioCheck == true)
            {
                menuItem2.Visible = false;
            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            
            if (menuItem2.Enabled == true)
            {
                MessageBox.Show("This is my second project in the subject");
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this application?",
               "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void exitCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this application?",
              "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {

        }
    }
}
