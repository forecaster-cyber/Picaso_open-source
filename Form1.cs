using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace paint_2._0
{
    public partial class Form1 : Form

    {

        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        






        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            



        }

        


        


        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            

        }

        


        private static Bitmap DrawControlToBitmap(Control control)

        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;



            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            moving = false;
            x = -1;
            y = -1;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Erase EVERYTHING!?", "T-800", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Refresh();
                panel1.BackgroundImage = pictureBox7.Image;

            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {

                panel1.BackColor = c.Color;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {

                pictureBox9.BackColor = c.Color;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            PictureBox p = (PictureBox)sender;
            pictureBox10.BackColor = panel1.BackColor;
            pen.Color = p.BackColor;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            panel1.BackgroundImage = pictureBox7.Image;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel3.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float p_w = float.Parse(textBox1.Text);


            pen.Width = p_w;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = DrawControlToBitmap(panel1);
            bitmap.Save(textBox11.Text + ".bmp");
            System.Diagnostics.Process.Start(textBox11.Text + ".bmp");

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.obj)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                 
                Image newImage = Image.FromFile((open.FileName));
                panel1.BackgroundImage = newImage;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox2.Text);
            float y = float.Parse(textBox3.Text);
            float x2 = float.Parse(textBox4.Text);
            float y2 = float.Parse(textBox5.Text);
            g.DrawLine(pen, x, y, x2, y2);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float x25 = float.Parse(textBox6.Text);
            float y25 = float.Parse(textBox7.Text);
            float h = float.Parse(textBox9.Text);
            float w = float.Parse(textBox8.Text);
            g.DrawRectangle(pen, x25,y25,w,h);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int o = int.Parse((textBox10.Text));
            pen.Color = Color.FromArgb(o, pen.Color);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int o = int.Parse((textBox10.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            label9.Text = x.ToString();
            label10.Text = y.ToString();
            
        }


        private void button10_Click(object sender, EventArgs e)
        {
            float i1 = float.Parse(textBox15.Text);
            float i2 = float.Parse(textBox14.Text);
            float i3 = float.Parse(textBox13.Text);
            float i4 = float.Parse(textBox12.Text);
            g.DrawEllipse(pen, i1,i2,i3,i4);
            
        }


        
    }
}
