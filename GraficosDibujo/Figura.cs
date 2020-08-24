using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraficosDibujo
{    
    public enum Figuras
    {
        LineaCurva, LineaRecta, Eliplse, Poligono, vacio
    }

    [Serializable]
    public class Figura
    {
        // Atributos del grafico de la figura
        public int x;
        public int y;
        public int Ancho;
        public int Alto;

        public Point[] puntos;     

        public int GrosorLinea = 1;
        public Color colorLinea = Color.Black;

        public bool Relleno = false;
        public Color ColorRelleno = Color.Empty;

        public bool oculto = false;

        public void Rellenar(Color color)
        {
            ColorRelleno = color;
            Relleno = true;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

    }

    [Serializable]
    public class LineaCurva : Figura
    {
        public bool Cerrada = false;

        public LineaCurva(Point[] puntos)
        {
            this.puntos = puntos;
        }

    }

    [Serializable]
    public class LineaRecta : Figura
    {
        public LineaRecta(int x1, int y1, int x2, int y2)
        {
            this.puntos = new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }
    }

    [Serializable]
    public class Poligono : Figura
    {
        public Poligono(Point[] puntos)
        {
            this.puntos = puntos;
        }
    }

    [Serializable]
    public class Elipse : Figura
    {        
        public Elipse(int x, int y, int Ancho, int Alto)
        {            
            this.x = x;
            this.y = y;
            this.Ancho = Ancho;
            this.Alto = Alto;
        }
    }    

}
