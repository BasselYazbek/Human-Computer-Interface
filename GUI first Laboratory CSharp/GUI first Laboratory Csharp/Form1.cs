using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_first_Laboratory_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my default message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is another default message");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this window?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Enabled == true && checkBox3.Enabled == false)
            {
                comboBox1.Enabled = true;
                Message.Enabled = false;
            }
            else if (checkBox4.Enabled == true && checkBox3.Enabled== true)
            {
                comboBox1.Enabled = true;
                Message.Enabled = true;
            }
            else if(checkBox4.Enabled == false && checkBox3.Enabled == false)
            {
                comboBox1.Enabled = false;
                Message.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked== false)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            else if (checkBox2.Checked == true && checkBox1.Checked == true)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked== true && checkBox1.Checked== false)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            }
            else if (checkBox2.Checked== false && checkBox1.Checked== false)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                Message.Enabled = true;
                comboBox1.Enabled = false;
            }
            else if (checkBox3.Enabled == false && checkBox4.Enabled == false)
            {
                Message.Enabled = false;
                comboBox1.Enabled = false;
            }
            else if (checkBox3.Enabled == true && checkBox4.Enabled == true)
            {
                Message.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Clear Field")
            {
                Message.Clear();
            }
            else if (comboBox1.Text == "Copy text")
            {
                Message.Text = Message.Text;
            }
            else if (comboBox1.Text == "Paste text")
            {
                Message.Text = Message.Text + Message.Text;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked== true)
            {
                MessageBox.Show("At least 1 of the Show Actions is shown");
            }
            else
            {
                MessageBox.Show("There isn't any 1 of the Show Actions activated");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked== true || checkBox4.Checked == true)
            {
                MessageBox.Show("At least 1 of the Enable actions is activated");
            }
            else
            {
                MessageBox.Show("The're isn't any enable action activated.");
            }
        }
    }
}
