namespace Human_Computer_lab_Work_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingtool = new System.Windows.Forms.GroupBox();
            this.myfigure = new System.Windows.Forms.RadioButton();
            this.brush = new System.Windows.Forms.RadioButton();
            this.pen = new System.Windows.Forms.RadioButton();
            this.drawingshapes = new System.Windows.Forms.GroupBox();
            this.square = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.RadioButton();
            this.black = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.cyan = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.magenta = new System.Windows.Forms.RadioButton();
            this.yellow = new System.Windows.Forms.RadioButton();
            this.white = new System.Windows.Forms.RadioButton();
            this.color = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.soundOptions = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voice = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.speed = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.drawingtool.SuspendLayout();
            this.drawingshapes.SuspendLayout();
            this.color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.soundOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingtool
            // 
            this.drawingtool.Controls.Add(this.myfigure);
            this.drawingtool.Controls.Add(this.brush);
            this.drawingtool.Controls.Add(this.pen);
            this.drawingtool.Location = new System.Drawing.Point(12, 12);
            this.drawingtool.Name = "drawingtool";
            this.drawingtool.Size = new System.Drawing.Size(191, 197);
            this.drawingtool.TabIndex = 1;
            this.drawingtool.TabStop = false;
            this.drawingtool.Text = "Drawing Tool";
            this.drawingtool.Enter += new System.EventHandler(this.drawingtool_Enter);
            // 
            // myfigure
            // 
            this.myfigure.AutoSize = true;
            this.myfigure.Location = new System.Drawing.Point(6, 143);
            this.myfigure.Name = "myfigure";
            this.myfigure.Size = new System.Drawing.Size(91, 21);
            this.myfigure.TabIndex = 2;
            this.myfigure.Text = "My Figure";
            this.myfigure.UseVisualStyleBackColor = true;
            this.myfigure.CheckedChanged += new System.EventHandler(this.myfigure_CheckedChanged);
            // 
            // brush
            // 
            this.brush.AutoSize = true;
            this.brush.Location = new System.Drawing.Point(6, 90);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(66, 21);
            this.brush.TabIndex = 1;
            this.brush.Text = "Brush";
            this.brush.UseVisualStyleBackColor = true;
            this.brush.CheckedChanged += new System.EventHandler(this.brush_CheckedChanged);
            // 
            // pen
            // 
            this.pen.AutoSize = true;
            this.pen.Location = new System.Drawing.Point(6, 42);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(54, 21);
            this.pen.TabIndex = 0;
            this.pen.Text = "Pen";
            this.pen.UseVisualStyleBackColor = true;
            this.pen.CheckedChanged += new System.EventHandler(this.pen_CheckedChanged);
            // 
            // drawingshapes
            // 
            this.drawingshapes.Controls.Add(this.square);
            this.drawingshapes.Controls.Add(this.circle);
            this.drawingshapes.Controls.Add(this.line);
            this.drawingshapes.Location = new System.Drawing.Point(13, 225);
            this.drawingshapes.Name = "drawingshapes";
            this.drawingshapes.Size = new System.Drawing.Size(190, 192);
            this.drawingshapes.TabIndex = 2;
            this.drawingshapes.TabStop = false;
            this.drawingshapes.Text = "Drawing Shapes";
            this.drawingshapes.Enter += new System.EventHandler(this.drawingshapes_Enter);
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Location = new System.Drawing.Point(6, 142);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 21);
            this.square.TabIndex = 2;
            this.square.TabStop = true;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.CheckedChanged += new System.EventHandler(this.square_CheckedChanged);
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(6, 91);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(64, 21);
            this.circle.TabIndex = 1;
            this.circle.TabStop = true;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.CheckedChanged += new System.EventHandler(this.circle_CheckedChanged);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(6, 40);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(56, 21);
            this.line.TabIndex = 0;
            this.line.TabStop = true;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.CheckedChanged += new System.EventHandler(this.line_CheckedChanged);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(6, 35);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(63, 21);
            this.black.TabIndex = 0;
            this.black.TabStop = true;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            this.black.CheckedChanged += new System.EventHandler(this.black_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(6, 82);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 21);
            this.blue.TabIndex = 1;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(6, 129);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(69, 21);
            this.green.TabIndex = 2;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // cyan
            // 
            this.cyan.AutoSize = true;
            this.cyan.Location = new System.Drawing.Point(6, 176);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(61, 21);
            this.cyan.TabIndex = 3;
            this.cyan.TabStop = true;
            this.cyan.Text = "Cyan";
            this.cyan.UseVisualStyleBackColor = true;
            this.cyan.CheckedChanged += new System.EventHandler(this.cyan_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(6, 223);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 21);
            this.red.TabIndex = 4;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.CheckedChanged += new System.EventHandler(this.red_CheckedChanged);
            // 
            // magenta
            // 
            this.magenta.AutoSize = true;
            this.magenta.Location = new System.Drawing.Point(6, 270);
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(84, 21);
            this.magenta.TabIndex = 5;
            this.magenta.TabStop = true;
            this.magenta.Text = "Magenta";
            this.magenta.UseVisualStyleBackColor = true;
            this.magenta.CheckedChanged += new System.EventHandler(this.magenta_CheckedChanged);
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Location = new System.Drawing.Point(6, 317);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(69, 21);
            this.yellow.TabIndex = 6;
            this.yellow.TabStop = true;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.CheckedChanged += new System.EventHandler(this.yellow_CheckedChanged);
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(6, 364);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(65, 21);
            this.white.TabIndex = 7;
            this.white.TabStop = true;
            this.white.Text = "White";
            this.white.UseVisualStyleBackColor = true;
            this.white.CheckedChanged += new System.EventHandler(this.white_CheckedChanged);
            // 
            // color
            // 
            this.color.Controls.Add(this.white);
            this.color.Controls.Add(this.yellow);
            this.color.Controls.Add(this.magenta);
            this.color.Controls.Add(this.red);
            this.color.Controls.Add(this.cyan);
            this.color.Controls.Add(this.green);
            this.color.Controls.Add(this.blue);
            this.color.Controls.Add(this.black);
            this.color.Location = new System.Drawing.Point(262, 12);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(169, 409);
            this.color.TabIndex = 3;
            this.color.TabStop = false;
            this.color.Text = "Color";
            this.color.Enter += new System.EventHandler(this.color_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(485, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 396);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(102, 45);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(185, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // soundOptions
            // 
            this.soundOptions.Controls.Add(this.start);
            this.soundOptions.Controls.Add(this.comboBox1);
            this.soundOptions.Controls.Add(this.voice);
            this.soundOptions.Controls.Add(this.trackBar2);
            this.soundOptions.Controls.Add(this.speed);
            this.soundOptions.Controls.Add(this.volume);
            this.soundOptions.Controls.Add(this.trackBar1);
            this.soundOptions.Location = new System.Drawing.Point(127, 427);
            this.soundOptions.Name = "soundOptions";
            this.soundOptions.Size = new System.Drawing.Size(703, 232);
            this.soundOptions.TabIndex = 6;
            this.soundOptions.TabStop = false;
            this.soundOptions.Text = "Sound Options";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(465, 155);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(179, 43);
            this.start.TabIndex = 11;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(136, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // voice
            // 
            this.voice.AutoSize = true;
            this.voice.Location = new System.Drawing.Point(58, 174);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(43, 17);
            this.voice.TabIndex = 9;
            this.voice.Text = "Voice";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(477, 44);
            this.trackBar2.Maximum = 3;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(158, 56);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(397, 53);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(49, 17);
            this.speed.TabIndex = 7;
            this.speed.Text = "Speed";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(34, 53);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(55, 17);
            this.volume.TabIndex = 6;
            this.volume.Text = "Volume";
            this.volume.Click += new System.EventHandler(this.volume_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(420, 665);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(101, 44);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 742);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.soundOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.drawingshapes);
            this.Controls.Add(this.drawingtool);
            this.Name = "Form1";
            this.Text = "C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.drawingtool.ResumeLayout(false);
            this.drawingtool.PerformLayout();
            this.drawingshapes.ResumeLayout(false);
            this.drawingshapes.PerformLayout();
            this.color.ResumeLayout(false);
            this.color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.soundOptions.ResumeLayout(false);
            this.soundOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox drawingtool;
        private System.Windows.Forms.RadioButton myfigure;
        private System.Windows.Forms.RadioButton brush;
        private System.Windows.Forms.RadioButton pen;
        private System.Windows.Forms.GroupBox drawingshapes;
        private System.Windows.Forms.RadioButton square;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.RadioButton line;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton cyan;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton magenta;
        private System.Windows.Forms.RadioButton yellow;
        private System.Windows.Forms.RadioButton white;
        private System.Windows.Forms.GroupBox color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox soundOptions;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label voice;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Button exit;
    }
}

