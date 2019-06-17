﻿namespace MiniPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_gradient2 = new System.Windows.Forms.Button();
            this.btn_gradient1 = new System.Windows.Forms.Button();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btn_PenColor);
            this.panel1.Controls.Add(this.cmb_PenSize);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FloralWhite;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(577, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(137, 64);
            this.panel9.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FloralWhite;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txt_ShapeSize);
            this.panel6.Controls.Add(this.btn_Square);
            this.panel6.Controls.Add(this.btn_Rectangle);
            this.panel6.Controls.Add(this.btn_Circle);
            this.panel6.Location = new System.Drawing.Point(434, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 64);
            this.panel6.TabIndex = 5;
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(8, 34);
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(117, 20);
            this.txt_ShapeSize.TabIndex = 9;
            this.txt_ShapeSize.Text = "10";
            // 
            // btn_Square
            // 
            this.btn_Square.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Square.BackgroundImage")));
            this.btn_Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Square.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Square.Location = new System.Drawing.Point(8, 2);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(30, 27);
            this.btn_Square.TabIndex = 5;
            this.btn_Square.UseVisualStyleBackColor = false;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.BackgroundImage")));
            this.btn_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(52, 2);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(30, 27);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Circle.BackgroundImage")));
            this.btn_Circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(95, 2);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(30, 27);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(291, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 64);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Open...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.Location = new System.Drawing.Point(59, 9);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(76, 26);
            this.btn_PenColor.TabIndex = 2;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_PenSize.Location = new System.Drawing.Point(59, 40);
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(76, 21);
            this.cmb_PenSize.TabIndex = 1;
            this.cmb_PenSize.Text = "1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_gradient2);
            this.panel4.Controls.Add(this.btn_gradient1);
            this.panel4.Controls.Add(this.btn_CanvasColor);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(148, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 64);
            this.panel4.TabIndex = 2;
            // 
            // btn_gradient2
            // 
            this.btn_gradient2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_gradient2.Location = new System.Drawing.Point(105, 30);
            this.btn_gradient2.Name = "btn_gradient2";
            this.btn_gradient2.Size = new System.Drawing.Size(25, 25);
            this.btn_gradient2.TabIndex = 0;
            this.btn_gradient2.UseVisualStyleBackColor = false;
            this.btn_gradient2.Click += new System.EventHandler(this.btn_gradient2_Click);
            // 
            // btn_gradient1
            // 
            this.btn_gradient1.BackColor = System.Drawing.Color.Red;
            this.btn_gradient1.Location = new System.Drawing.Point(68, 30);
            this.btn_gradient1.Name = "btn_gradient1";
            this.btn_gradient1.Size = new System.Drawing.Size(25, 25);
            this.btn_gradient1.TabIndex = 6;
            this.btn_gradient1.UseVisualStyleBackColor = false;
            this.btn_gradient1.Click += new System.EventHandler(this.btn_gradient1_Click);
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CanvasColor.Location = new System.Drawing.Point(68, 5);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(64, 24);
            this.btn_CanvasColor.TabIndex = 4;
            this.btn_CanvasColor.UseVisualStyleBackColor = false;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 51);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 64);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-1, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 100);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(4, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "1";
            // 
            // button2
            // 
            this.button2.Image = global::MiniPaint.Properties.Resources.pencil;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pen Tool";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Draw.Location = new System.Drawing.Point(12, 99);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(720, 340);
            this.pnl_Draw.TabIndex = 2;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.TextBox txt_ShapeSize;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Button btn_gradient1;
        private System.Windows.Forms.Button btn_gradient2;
        private System.Windows.Forms.Label label1;
    }
}

