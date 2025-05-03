using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPelota
{
    class Pelota
    {
        private double x;
        private double y;
        private double radio;
        private int color;

        private double angulo;
        private double sentido;

        private bool estado;

        private double XMax;
        private double YMax;
        private Random r;
        public Pelota(double XMax, double YMax, Random r, int id, int n)
        {
            

            x = ((2 * id + 1) * XMax) / (2 * n);
            y = YMax/2;
            radio = XMax / (20 * n);
            color = r.Next(1, 7);
            estado = false;
            this.XMax = XMax;
            this.YMax = YMax;
            this.r = r;
            angulo = r.Next(0 , 90);            
            sentido = 1;
        }

        private Brush GetColor()
        {
            Brush res = null;

            switch(color)
            {
                case 1:
                    res = Brushes.Magenta;
                    break;
                case 2:
                    res = Brushes.Red;
                    break;
                case 3:
                    res = Brushes.Green;
                    break;
                case 4:
                    res = Brushes.Cyan;
                    break;
                case 5:
                    res = Brushes.Brown;
                    break;
                case 6:
                    res = Brushes.Black;
                    break;
                case 7:
                    res = Brushes.Yellow;
                    break;
                default:
                    res = Brushes.Blue;
                    break;
            }

            return res;
        }

        public void Dibujar(Graphics graphics)
        {
            graphics.FillEllipse(GetColor(),
                (int)(x - radio), (int)(y - radio),
                (int)(2 * radio), (int)(2 * radio));
        }

        public void Borrar(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.White,
                (int)(x - radio), (int)(y - radio),
                (int)(2 * radio), (int)(2 * radio));
        }

        private void Rebotar()
        {
            if (y - radio <= 0 || y + radio >= YMax)
            {
                if (Math.Abs(angulo) == 90)
                {
                    sentido = -sentido;
                }
                else if (Math.Abs(angulo) > 45)
                {
                    sentido = -sentido;
                    angulo = -angulo;
                }
                else if (Math.Abs(angulo) <= 45)
                {
                    angulo = -angulo;
                }
            }

            if (x - radio <= 0 || x + radio >= XMax)
            {
                if (Math.Abs(angulo) > 45)
                {
                    angulo = -angulo;
                }
                else if (Math.Abs(angulo) <= 45)
                {
                    sentido = -sentido;
                    angulo = -angulo;
                }
            }
        }

        private void Desplazarse()
        {
            if (Math.Abs(angulo) == 90)
            {
                y += sentido;
            }
            else if (Math.Abs(angulo) > 45)
            {
                double rad = (Math.PI * angulo) / 180;
                x += (sentido / Math.Tan(rad));
                y += sentido;
            }
            else if (Math.Abs(angulo) <= 45)
            {
                double rad = (Math.PI * angulo) / 180;
                x += sentido;
                y += (sentido * Math.Tan(rad));
            }
        }

        public void Mover()
        {
            Rebotar();
            Desplazarse();
        }

        public bool GetEstado()
        {
            return estado;
        }

        public void CambiaEstado()
        {
            estado = !estado;
        }
    }
}
