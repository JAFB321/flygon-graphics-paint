using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosDibujo
{
    public partial class Main : Form
    {
        #region Componentes
        DibujadorGraficos graficos;
        Tools tools;

        bool Dibujando = false;
        Figuras FigDibujando = Figuras.vacio;
        List<Point> puntos = new List<Point>();
        #endregion


        public Main()
        {
            InitializeComponent();
            graficos = new DibujadorGraficos(this);
            tools = new Tools(graficos, this);
            tools.Show();
            tools.Focus();

            tools.Location = new Point(0, 200);
            this.Location = new Point(tools.Width, 200);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;



            graficos.Paint();
             base.OnPaint(e);
        }

        #region Metodos Tools
        public void ActivarDibujarFigura(Figuras figura)
        {
            if (Dibujando) return;
            Dibujando = true;

            tools.Bloqueado = true;
            FigDibujando = figura;            
        }

        #endregion

        #region Eventos para Tools
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FigDibujando == Figuras.vacio) return;

            if (FigDibujando == Figuras.LineaRecta)
            {
                if (puntos.Count == 1)
                {
                    puntos.Add(new Point(e.X, e.Y));
                    LineaRecta lin = new LineaRecta(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
                    puntos.Clear();
                    Dibujando = false;
                    FigDibujando = Figuras.vacio;
                    tools.Bloqueado = false;
                    tools.figura = lin;
                    return;

                }
                puntos.Add(new Point(e.X, e.Y));
            }

            else if (FigDibujando == Figuras.LineaCurva || FigDibujando == Figuras.Poligono)
            {
                puntos.Add(new Point(e.X, e.Y));
            }

            else if (FigDibujando == Figuras.Eliplse)
            {
                Elipse eli = new Elipse(e.X, e.Y, 100, 50);
                Dibujando = false;
                FigDibujando = Figuras.vacio;
                tools.Bloqueado = false;
                tools.figura = eli;
                return;
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!Dibujando) return;
                if (puntos.Count == 0) return;
                if(FigDibujando == Figuras.LineaCurva)
                {
                    LineaCurva lin = new LineaCurva(puntos.ToArray());
                    puntos.Clear();
                    Dibujando = false;
                    FigDibujando = Figuras.vacio;
                    tools.Bloqueado = false;
                    tools.figura = lin;
                    return;
                }
                else if (FigDibujando == Figuras.Poligono)
                {
                    Poligono pol = new Poligono(puntos.ToArray());
                    puntos.Clear();
                    Dibujando = false;
                    FigDibujando = Figuras.vacio;
                    tools.Bloqueado = false;
                    tools.figura = pol;
                    return;
                }
            }

        }


        #endregion


    }



}
