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

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 163)
            {
                panel2.Height = 32;
            }
            else
            {
                panel2.Height = 163;
            }

            contextMenuStrip1.Show(button1, 100, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this application?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == true)
            {
                MessageBox.Show("This is my second project in the subject");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 80)
            {
                panel1.Height = 32;
            }
            else
            {
                panel1.Height = 80;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled == true)
            {
                MessageBox.Show("Hello all!\nThis is a menu program which inside it you can display message, you can make the message field unavailable and also you can exit the program.\nMoreover there will be another functions also.\nThis program has been created in: 7 Oct 2022");
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        // The names for the 2 buttons that it will be added
        string first = "Edit item";
        string second = "Edit item";
        string third = "Format";
        string forth = "Format";
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString()== "M")
            {
                button3.PerformClick();
            }
            
            else if (e.Control && e.KeyCode.ToString() == "C")
            {
                checkBox1.Checked = true;
                if((e.Control && e.KeyCode.ToString() == "C")){
                    checkBox1.Checked = false;
                }
            }
            
            else if (e.Control && e.KeyCode.ToString() == "E")
            {
                button4.PerformClick();
            }
            else if (e.Control && e.KeyCode.ToString() == "A")
            {
                button6.PerformClick();
            }
            else if (e.KeyCode.ToString() == "A")
            {
                Button btn1 = new Button();
                btn1.Text = first.ToString();
                btn1.Name = first.ToString();
                btn1.Size =new Size(200,41);
                btn1.Location = new Point(0, 125);
                panel2.Controls.Add(btn1);

                Button btn2 = new Button();
                btn2.Text = second.ToString();
                btn2.Name = second.ToString();
                btn2.Size = new Size(204, 41);
                btn2.Location = new Point(0,55);
                panel1.Controls.Add(btn2);

                
            }
            else if (e.KeyCode.ToString() == "C")
            {
                Button btn3 = new Button();
                btn3.Text = third.ToString();
                btn3.Name = third.ToString();
                btn3.Size = new Size(200, 41);
                btn3.Location = new Point(0, 125);
                panel2.Controls.RemoveAt(4);
                panel2.Controls.Add(btn3);

                Button btn4 = new Button();
                btn4.Text = forth.ToString();
                btn4.Name = forth.ToString();
                btn4.Size= new Size(200, 55);
                btn4.Location = new Point(0, 51);
                panel1.Controls.RemoveAt(2);
                panel1.Controls.Add(btn4);
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
            if(pictureBox1.Enabled == true)
            {
                MessageBox.Show("In case you are facing any problem\n Please contact us using email or live chat and our team will help you.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The file word will be copied");
            if(pictureBox2.Enabled== true)
            {
                button1.Text = button1.Text + button1.Text;
            }
            
        }

        private void checkCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkCtrlCToolStripMenuItem.Enabled == true)
            {
                //button2.PerformClick();
            }
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
                button3.PerformClick();
            }
        }

        private void exitCtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(exitCtrlEToolStripMenuItem.Enabled== true)
            {
                button4.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button3.Hide();
            }
            else
            {
                button3.Show();
            }
        }
    }
}
