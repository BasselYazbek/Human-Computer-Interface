namespace Human_Computer_lab_work_2_Csharp
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Human_Computer_lab_work_2_Csharp.Properties.Resources.Untitled11;
            this.pictureBox2.Location = new System.Drawing.Point(488, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Human_Computer_lab_work_2_Csharp.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(575, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem7});
            this.menuItem1.Text = "File";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Message";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Checked = true;
            this.menuItem3.Index = 1;
            this.menuItem3.RadioCheck = true;
            this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem3.Text = "Check ";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItem4.Text = "Exit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "Edit Item";
            this.menuItem7.Visible = false;
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem8});
            this.menuItem5.Text = "Help";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuItem6.Text = "About";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.messageToolStripMenuItem.Text = "Message        Ctrl + M";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // checkCtrlCToolStripMenuItem
            // 
            this.checkCtrlCToolStripMenuItem.Checked = true;
            this.checkCtrlCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCtrlCToolStripMenuItem.Name = "checkCtrlCToolStripMenuItem";
            this.checkCtrlCToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.checkCtrlCToolStripMenuItem.Text = "Check           Ctrl + C";
            this.checkCtrlCToolStripMenuItem.Click += new System.EventHandler(this.checkCtrlCToolStripMenuItem_Click);
            // 
            // exitCtrlEToolStripMenuItem
            // 
            this.exitCtrlEToolStripMenuItem.Name = "exitCtrlEToolStripMenuItem";
            this.exitCtrlEToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.exitCtrlEToolStripMenuItem.Text = "Exit               Ctrl + E";
            this.exitCtrlEToolStripMenuItem.Click += new System.EventHandler(this.exitCtrlEToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripMenuItem,
            this.checkCtrlCToolStripMenuItem,
            this.exitCtrlEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "Edit Item";
            this.menuItem8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCtrlEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
    }
}

