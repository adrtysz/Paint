using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }

        bool startPaint = false;
        Graphics g;
        //nullable int for storing Null value
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        //Event fired when the mouse pointer is moved over the Panel(pnl_Draw).
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if(startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(btn_PenColor.BackColor,float.Parse(cmb_PenSize.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and Heigt value from Textbox(txt_ShapeSize)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                //setting startPaint and drawSquare value to false for creating one graphic on one click.
                startPaint = false;
                drawSquare = false;
            }
            if(drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                //setting the width twice of the height
                g.FillRectangle(sb, e.X, e.Y, 2*int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if(drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }
        //Fired when the mouse pointer is over the pnl_Draw and a mouse button is released.
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
        //Button for Setting pen Color
        private void button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }
        //New 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the Panel(pnl_Draw)
            g.Clear(pnl_Draw.BackColor);
            //Setting the BackColor of pnl_draw and btn_CanvasColor to White on Clicking New under File Menu
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
            pnl_Draw.BackgroundImage = null;
        }
       //Setting the Canvas Color
        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                pnl_Draw.BackColor = c.Color;
                btn_CanvasColor.BackColor = c.Color;
            }
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
        //Exit under File Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pnl_Draw.BackgroundImage = new Bitmap(open.FileName);
                pnl_Draw.BackColor = Color.White;
                // image file path  
                // textBox1.Text = open.FileName;

            }
        }

        private void btn_gradient2_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_gradient2.BackColor = c.Color;
            }

            Rectangle gradient_rectangle = new Rectangle(0, 0, pnl_Draw.Width, pnl_Draw.Height);

            //define gradient's properties
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(gradient_rectangle, btn_gradient1.BackColor, c.Color,65f);

            //apply gradient         
            g.FillRectangle(b, gradient_rectangle);
        }

        private void btn_gradient1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_gradient1.BackColor = c.Color;
            }
        }

        
    }
}
