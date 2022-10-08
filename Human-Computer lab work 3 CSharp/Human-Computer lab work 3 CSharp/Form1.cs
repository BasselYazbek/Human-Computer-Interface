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
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public TextBox tb1;
        public Button bt;

        public Form1()
        {
            InitializeComponent();
            form1 = this;
            tb1 = textBox1;
            bt = button5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yes, No, or Cancel?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                textBox1.Text = "Yes";
            }
            else if (dr == DialogResult.No)
            {
                textBox1.Text = "No";
            }
            else
            {
                textBox1.Text = "Cancel";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Abort, Retry, Ignore", "Confirm", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

            if (dr == DialogResult.Abort)
            {
                textBox1.Text = "Abort";
            }
            else if (dr == DialogResult.Retry)
            {
                textBox1.Text = "Retry";
            }
            else
            {
                textBox1.Text = "Ignore";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Enabled == true)
            {
                MessageBox.Show("The File opened is:\nLaboratory Work 3");
                textBox1.Text = "Laboratory Work 3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Message and option dialog", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                button5.Enabled = true;
                Form2 f2 = new Form2();
                Form2.form2.tb1.Text = "Message and option Dialog";
                f2.Show();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
