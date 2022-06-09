using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        //int aR, aG, aB;
        int[] almacena = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(10, 10);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            /* Bitmap bmp = new Bitmap(pictureBox1.Image);
             Color c = new Color();
             c = bmp.GetPixel(e.X, e.Y);
             textBox1.Text = c.R.ToString();
             textBox2.Text = c.G.ToString();
             textBox3.Text = c.B.ToString();
             cR = c.R;
             cG = c.G;
             cB = c.B; */
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            int x, y, mR = 0, mG = 0, mB = 0;
            x = e.X; y = e.Y;
            for (int i=x; i<x+10; i++)
                for (int j=y; j<y+10; j++)
                {
                    c = bmp.GetPixel(i,j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mG + c.B;
                }
            mR = mR / 100;
            mG = mR / 100;
            mB = mB / 100;
            cR = mR;
            cG = mR;
            cB = mB;
            textBox1.Text = cR.ToString();
            textBox2.Text = cG.ToString();
            textBox3.Text = cB.ToString();   
        }

        private void Copiar(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap copia = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for(int i=1; i<bmp.Width; i++) 
                for (int j=1; j<bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    copia.SetPixel(i,j,c);
                }
            pictureBox2.Image = copia;
        }
        private void button8_Click(object sender, EventArgs e)
        {
           almacena[0]=cR;
            almacena[1] = cG;
            almacena[2] = cB;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            almacena[3] = cR;
            almacena[4] = cG;
            almacena[5] = cB;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap copia = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;
                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;
                    if (((almacena[3] - 10) < meR) && (meR < (almacena[3] + 10)) && ((almacena[4] - 10) < meG) && (meG < (almacena[4] + 10)) && ((almacena[5] - 10) < meB) && (meB < (almacena[5] + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                copia.SetPixel(k, l, Color.Pink);
                            }
                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                copia.SetPixel(k, l, c);
                            }

                }
            pictureBox2.Image = copia;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap copia = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;
                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;
                    if (((almacena[6] - 10) < meR) && (meR < (almacena[6] + 10)) && ((almacena[7] - 10) < meG) && (meG < (almacena[7] + 10)) && ((almacena[8] - 10) < meB) && (meB < (almacena[8] + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                copia.SetPixel(k, l, Color.Red);
                            }
                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                copia.SetPixel(k, l, c);
                            }

                }
            pictureBox2.Image = copia;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            almacena[6] = cR;
            almacena[7] = cG;
            almacena[8] = cB;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap copia = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;
                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;
                    if (((almacena[0] - 10) < meR) && (meR < (almacena[0] + 10)) && ((almacena[1] - 10) < meG) && (meG < (almacena[1] + 10)) && ((almacena[2] - 10) < meB) && (meB < (almacena[3] + 10)))
                        for (int k=i; k<i+10; k++)
                            for(int l=j; l < j + 10; l++)
                            {
                                copia.SetPixel(k, l, Color.Black);
                            }
                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k,l);
                                copia.SetPixel(k, l, c);
                            }

                }
            pictureBox2.Image = copia;

        }
    }
}
