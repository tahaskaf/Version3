using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {// VARIABLES
        int x = 307;
        int y = 167;

        int mov = 1;
        int cont = 0;
        

        int Dado1=0;
        int Dado2=0;

       static Timer tiempo_ficha = new Timer();
       static int t = 0;
        static bool exitFlag = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Mover_Ficha()
        {
            int d = Dado1 + Dado2;
            int i;

            for (i= 0; i < d; i++)
            {
                if (mov == 1)
                {
                    y = y + 40;
                }
                if (mov == 2)
                {
                    x = x - 40;
                }
                if (mov == 3)
                {
                    y = y + 80;
                }
                if (mov == 4)
                {
                    x = x + 40;
                }
                if (mov == 5)
                {
                    x = x + 80;
                }
                if (mov == 6)
                {
                    y = y - 40;
                }
                if (mov == 7)
                {
                    y = y - 80;
                }
                if (mov == 8)
                {
                    x = x - 80;
                }

                //Movimiento
                if ((mov == 1) && (y > 310) && (cont == 0))
                {
                    mov = 2;
                    x = 290;
                    y = 320;
                    cont++;
                }
                if ((mov == 2) && (x < 40) && (cont == 1))
                {
                    mov = 3;
                    cont++;
                }
                if ((mov == 3) && (y > 440) && (cont == 2))
                {
                    mov = 4;
                    cont++;
                }
                if ((mov == 4) && (x > 310) && (cont == 3))
                {
                    mov = 1;
                    x = 320;
                    y = 490;
                    cont++;
                }
                if ((mov == 1) && (y > 760) && (cont == 4))
                {
                    mov = 5;
                    x = 320;
                    y = 780;
                    cont++;
                }
                if ((mov == 5) && (x > 440) && (cont == 5))
                {
                    mov = 6;
                    x = 480;
                    y = 770;
                    cont++;
                }
                if ((mov == 6) && (y < 470) && (cont == 6))
                {
                    mov = 4;
                    x = 490;
                    y = 480;
                    cont++;
                }
                if ((mov == 4) && (x > 760) && (cont == 7))
                {
                    mov = 7;
                    x = 770;
                    y = 480;
                    cont++;
                }
                if ((mov == 7) && (y < 360) && (cont == 8))
                {
                    mov = 2;
                    x = 770;
                    y = 320;
                    cont++;
                }
                if ((mov == 2) && (x < 490) && (cont == 9))
                {
                    mov = 6;
                    x = 480;
                    y = 305;
                    cont++;
                }
                if ((mov == 6) && (y < 40) && (cont == 10))
                {
                    mov = 8;
                    x = 480;
                    y = 7;
                    cont++;
                }
                if ((mov == 8) && (x < 440) && (cont == 11))
                {
                    mov = 1;
                    x = 393;
                    y = 7;
                    cont++;
                }
                if ((mov == 1) && (y > 320) && (cont == 12))
                {
                    cont++;
                    mov = 0;
                }
            }
            Tablero.Refresh();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            picDado1.Refresh();
            picDado2.Refresh();
            
            Random tirada = new Random();
            Dado1 = tirada.Next(1,7);
            Dado2 = tirada.Next(1, 7);

            //DADO 1
            if (Dado1 == 1)
            {
                picDado1.Image = Image.FromFile("1.jpg");
            }
            if (Dado1 == 2)
            {
                picDado1.Image = Image.FromFile("2.jpg");
            }
            if (Dado1 == 3)
            {
                picDado1.Image = Image.FromFile("3.jpg");
            }
            if (Dado1 == 4)
            {
                picDado1.Image = Image.FromFile("4.jpg");
            }
            if (Dado1 == 5)
            {
                picDado1.Image = Image.FromFile("5.jpg");
            }
            if (Dado1 == 6)
            {
                picDado1.Image = Image.FromFile("6.jpg");
            }

            //DADO 2
            if (Dado2 == 1)
            {
                picDado2.Image = Image.FromFile("1.jpg");
            }
            if (Dado2 == 2)
            {
                picDado2.Image = Image.FromFile("2.jpg");
            }
            if (Dado2 == 3)
            {
                picDado2.Image = Image.FromFile("3.jpg");
            }
            if (Dado2 == 4)
            {
                picDado2.Image = Image.FromFile("4.jpg");
            }
            if (Dado2 == 5)
            {
                picDado2.Image = Image.FromFile("5.jpg");
            }
            if (Dado2 == 6)
            {
                picDado2.Image = Image.FromFile("6.jpg");
            }

            Mover_Ficha();

            if ((Dado1 == Dado2) && (Dado1!=0))
            {
                MessageBox.Show("DOBLES!!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Tablero_MouseMove(object sender, MouseEventArgs e)
        {
            miPosicion.Text = "X= " + e.X + "Y= " + e.Y;
        }

        public void Tablero_Paint(object sender, PaintEventArgs e)
        {
            //Tablero.Invalidate();
            
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            SolidBrush myBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(myBrush, x, y, 26, 26);
        }

        

        private void Mover_Click(object sender, EventArgs e)
        {
            int d = Dado1 + Dado2;
            if (mov == 1)
            {
              y = y + 40*d;
            }
            if (mov == 2)
            {
              x = x - 40*d;
            }
            if (mov == 3)
            {
               y = y + 80*d;
            }
            if (mov == 4)
            {
               x = x + 40 * d;
            }
            if (mov == 5)
            {
               x = x + 80 * d;
            }
            if (mov == 6)
            {
                y = y - 40*d;
            }
            if (mov == 7)
            {
                y = y - 80*d;
            }
            if (mov == 8)
            {
                x = x - 80*d;
            }

            //Movimiento
            if ((mov ==1) && (y > 310) && (cont==0))
            {
                mov = 2;
                x = 290;
                y = 320;
                cont++;
            }
            if ((mov == 2) && (x < 40) && (cont==1))
            {
                mov = 3;
                cont++;
            }
            if ((mov == 3) && (y > 440) && (cont == 2))
            {
                mov = 4;
                cont++;
            }
            if ((mov == 4) && (x > 310) && (cont == 3))
            {
                mov = 1;
                x = 320;
                y = 490;
                cont++;
            }
            if ((mov == 1) && (y > 760) && (cont == 4))
            {
                mov = 5;
                x = 320;
                y = 780;
                cont++;
            }
            if ((mov == 5) && (x > 440) && (cont == 5))
            {
                mov = 6;
                x = 480;
                y = 770;
                cont++;
            }
            if ((mov == 6) && (y < 470) && (cont == 6))
            {
                mov = 4;
                x =490;
                y = 480;
                cont++;
            }
            if ((mov == 4) && (x > 760) && (cont == 7))
            {
                mov = 7;
                x = 770;
                y = 480;
                cont++;
            }
            if ((mov == 7) && (y < 360) && (cont == 8))
            {
                mov = 2;
                x = 770;
                y = 320;
                cont++;
            }
            if ((mov == 2) && (x < 490) && (cont == 9))
            {
                mov = 6;
                x = 480;
                y = 305;
                cont++;
            }
            if ((mov == 6) && (y < 40) && (cont == 10))
            {
                mov = 8;
                x = 480;
                y = 7;
                cont++;
            }
            if ((mov == 8) && (x < 440) && (cont == 11))
            {
                mov = 1;
                x = 393;
                y = 7;
                cont++;
            }
            if ((mov == 1) && (y > 320) && (cont == 12))
            {
                cont++;
                mov = 0;
            
                
                
            }
            Tablero.Refresh();

        }
    }
}
