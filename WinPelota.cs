using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPelota
{
    public partial class WinPelota : Form
    {
        private Pelota pelota0;
        private Pelota pelota1;
        private Random r;
        public WinPelota()
        {
            InitializeComponent();
            //pelota = new Pelota();
            r = new Random();
            pelota0 = new Pelota(pbCancha.Width, pbCancha.Height, r , 0 , 1);
            pelota1 = new Pelota(pbCancha.Width, pbCancha.Height, r , 0 , 1);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            //pelota.Borrar(pbCancha.CreateGraphics());
            pelota0.Mover();
            pelota1.Mover();
            pbCancha.Invalidate();
            pbCancha.Invalidate();

        }

        private void pbCancha_Paint(object sender, PaintEventArgs e)
        {
            pelota0.Dibujar(e.Graphics);
            pelota1.Dibujar(e.Graphics);
        }
    }
}
