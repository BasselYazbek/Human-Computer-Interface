using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using System.Media;
using WMPLib;

namespace Human_Computer_lab_Work_4
{

    public partial class Form1 : Form
    {
        //private SoundPlayer _soundplayer;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        
        // Drawing color
        Pen black1 = new Pen(Color.Black);
        Pen blue1 = new Pen(Color.Blue);
        Pen green1 = new Pen(Color.Green);
        Pen cyan1 = new Pen(Color.Cyan);
        Pen red1 = new Pen(Color.Red);
        Pen magenta1 = new Pen(Color.Magenta);
        Pen yellow1 = new Pen(Color.Yellow);
        Pen white1 = new Pen(Color.White);


        //drawing shape
        Rectangle circleee = new Rectangle(100, 100, 100, 100);
        Rectangle lineee = new Rectangle(100, 100, 10, 100);
        Rectangle squ = new Rectangle(100, 100, 80, 80);

        // drawing method


        public Form1()
        {
            InitializeComponent();

        }

        private void pen_CheckedChanged(object sender, EventArgs e)
        {


            /*
            if (pen.Checked == true && line.Checked == true && black.Checked == true)
            {
                this.CreateGraphics().DrawPie(Pens.Red, 400, 100, 200, 200, 0, 360);

            }
            */
        }

        private void brush_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void myfigure_CheckedChanged(object sender, EventArgs e)
        {
            if (myfigure.Checked == true)
            {
                pictureBox1.Image = Properties.Resources._21390394;
            }
        }

        private void drawingtool_Enter(object sender, EventArgs e)
        {

        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {

            //pictureBox1.CreateGraphics().DrawLine(yellow1, 50, 50, 50, 200);

            /*
            if (color.Enabled == true)
            {
                drawingShapesss = DrawingShapes.line;
            }
            */
        }

        private void circle_CheckedChanged(object sender, EventArgs e)
        {

            /*
            if (color.Enabled == true)
            {
                drawingShapesss = DrawingShapes.circle;
            }
            */
        }

        private void square_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (color.Enabled == true)
            {
                drawingShapesss = DrawingShapes.square;
            }
            */
        }

        private void drawingshapes_Enter(object sender, EventArgs e)
        {
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && black.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(black1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && black.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(black1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && black.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawEllipse(black1, circleee);
            }
            /*
            else if (brush.Checked == true && line.Checked == true && black.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Black, lineee);
            }
            */
            else if (brush.Checked == true && square.Checked == true && black.Checked == true)
            {

                pictureBox1.CreateGraphics().FillRectangle(Brushes.Black, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && black.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Black, circleee);
            }
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && blue.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(blue1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && blue.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawLine(blue1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && blue.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(blue1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && blue.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Blue, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && blue.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Blue, circleee);
            }
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && green.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(green1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && green.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(green1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && green.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(green1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && green.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Green, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && green.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Green, circleee);
            }
        }

        private void cyan_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && cyan.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(cyan1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && cyan.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(cyan1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && cyan.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(cyan1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && cyan.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Cyan, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && cyan.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Cyan, circleee);
            }
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && red.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(red1, squ);

            }
            else if (brush.Checked == true && square.Checked == true && red.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Red, squ);
            }
            if (pen.Checked == true && line.Checked == true && red.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(red1, 50, 50, 100, 200);
            }
            if (pen.Checked == true && circle.Checked == true && red.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(red1, circleee);
            }
            else if (brush.Checked == true && circle.Checked == true && red.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Red, circleee);
            }
        }

        private void magenta_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && magenta.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(magenta1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && magenta.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(magenta1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && magenta.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(magenta1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && magenta.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Magenta, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && magenta.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Magenta, circleee);
            }
        }

        private void yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (square.Checked == true && yellow.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(yellow1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && yellow.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(yellow1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && yellow.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(yellow1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && yellow.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.Yellow, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && yellow.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.Yellow, circleee);
            }
        }

        private void white_CheckedChanged(object sender, EventArgs e)
        {

            if (square.Checked == true && white.Checked == true && pen.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawRectangle(white1, squ);
            }
            else if (pen.Checked == true && line.Checked == true && white.Checked == true)
            {

                pictureBox1.CreateGraphics().DrawLine(white1, 50, 50, 100, 200);
            }
            else if (pen.Checked == true && circle.Checked == true && white.Checked == true)
            {
                pictureBox1.CreateGraphics().DrawEllipse(white1, circleee);
            }
            else if (brush.Checked == true && square.Checked == true && white.Checked == true)
            {
                pictureBox1.CreateGraphics().FillRectangle(Brushes.White, squ);
            }
            else if (brush.Checked == true && circle.Checked == true && white.Checked == true)
            {
                pictureBox1.CreateGraphics().FillEllipse(Brushes.White, circleee);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            drawingShapesss = DrawingShapes.line;

            this.CenterToScreen();
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            /*
            switch (drawingShapesss)
            {
                case DrawingShapes.line:
                    e.Graphics.DrawLine(Pens.AliceBlue, 50, 50, 100, 50);

                    break;
                case DrawingShapes.circle:
                    e.Graphics.DrawEllipse(Pens.Beige, 150, 150, 80, 80);
                    break;
                case DrawingShapes.square:
                    e.Graphics.DrawRectangle(Pens.Blue, 80, 80, 60, 60);
                    break;
                default:
                    break;
            }
            */
            /*
             if (pen.Checked == true && red.Checked == true)
             {
                 e.Graphics.DrawEllipse(Pens.RosyBrown, circleee);

             }
             */
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
        }

        private void volume_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1" && start.Text == "Start")
            {
                
                start.Text = "Pause";
                player.URL = "0.mp3";
                player.controls.play();
                comboBox1.Enabled = false;
                
            }
            else if (comboBox1.Text == "1" && start.Text == "Pause")
            {
                start.Text = "Start";
                player.controls.stop();
                comboBox1.Enabled = true;
            }
            else if (comboBox1.Text == "2" && start.Text == "Start")
            {
                start.Text = "Pause";
                player.URL = "1.mp3";
                player.controls.play();
                comboBox1.Enabled = false;
            }
            else if (comboBox1.Text == "2" && start.Text == "Pause")
            {
                start.Text = "Start";
                player.controls.stop();
                comboBox1.Enabled = true;
            }
            else if (comboBox1.Text == "3" && start.Text == "Start")
            {
                start.Text = "Pause";
                player.URL = "2.mp3";
                player.controls.play();
                comboBox1.Enabled = false;
            }
            else if (comboBox1.Text == "3" && start.Text == "Pause")
            {
                start.Text = "Start";
                player.controls.stop();
                comboBox1.Enabled = true;
            }
            else if (comboBox1.Text == "4" && start.Text == "Start")
            {
                start.Text = "Pause";
                player.URL = "3.mp3";
                player.controls.play();
                comboBox1.Enabled = false;
            }
            else if (comboBox1.Text == "4" && start.Text == "Pause")
            {
                start.Text = "Start";
                player.controls.stop();
                comboBox1.Enabled = true;
            }
            else if (comboBox1.Text == "5" && start.Text == "Start")
            {
                start.Text = "Pause";
                player.URL = "4.mp3";
                player.controls.play();
                comboBox1.Enabled = false;
            }
            else if (comboBox1.Text == "5" && start.Text == "Pause")
            {
                start.Text = "Start";
                player.controls.stop();
                comboBox1.Enabled = true;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
        }

        private void color_Enter(object sender, EventArgs e)
        {

        }
    }
}
