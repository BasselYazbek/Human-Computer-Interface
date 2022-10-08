using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Computer_lab_work_3_CSharp
{
    public partial class Form2 : Form
    {
        public static Form2 form2;
        public TextBox tb1;
        public GroupBox gb;
        public RadioButton rb1;
        public RadioButton rb2;
        public RadioButton rb3;
        public RadioButton rb4;
        public Button bt1;
        public Button bt2;


        public Form2()
        {
            InitializeComponent();
            form2 = this;
            tb1 = textBox2;
            gb = groupBox1;
            rb1 = radioButton1;
            rb2 = radioButton2;
            rb3 = radioButton3;
            rb4 = radioButton4;
            bt1 = button1;
            bt2 = button3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (radioButton1.Checked && button1.Enabled == true)
            {
                Form1.form1.tb1.Text = "Option 1";
            }
            else if(radioButton2.Checked && button1.Enabled== true)
            {
                Form1.form1.tb1.Text = "Option 2";
            }
            else if (radioButton3.Checked && button1.Enabled == true)
            {
                Form1.form1.tb1.Text = "Option 3";
            }
            else
            {
                Form1.form1.tb1.Text = "Option 4";
            }
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Enabled == true)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Retry or Cancel?", "Choose", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

            Form1 f1 = new Form1();
            if(dr == DialogResult.Retry)
            {
                Form1.form1.tb1.Text = "Retry";
            }
            else
            {
                Form1.form1.tb1.Text = "Cancel";
            }
            f1.Show();
        }
    }
}
