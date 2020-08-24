using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GraficosDibujo
{    
    public class DibujadorGraficos
    {

        #region Componentes
        Graphics g;
        public List<Figura> figuras = new List<Figura>();
        private Control control;
        public Figura UltimaFigura { get => figuras.Count > 0 ? figuras.Last() : null; }


        #endregion

        #region Constructor
        public DibujadorGraficos(Control control)
        {
            this.g = control.CreateGraphics();
            this.g.SmoothingMode = SmoothingMode.HighQuality;
            this.control = control;

        }
        #endregion
        
        #region Metodos
        public void AgregarFigura(Figura fig)
        {
            figuras.Add(fig);
            control.Refresh();
        }

        public void EliminarFigura(int index)
        {
            figuras.RemoveAt(index);
            control.Refresh();
        }

        public void EliminarUltima()
        {
            EliminarFigura(figuras.Count - 1);
        }

        public void CambiarOcultoFigura( int index)
        {
            if (figuras.Count <= index) return;
            Figura figura = figuras[index];
            figura.oculto = !figura.oculto;

            control.Refresh();
        }

        public void MoverCapaFigura(int indexFigura, int mov)
        {
            if (figuras.Count - 1 < (indexFigura + mov)) return;
            if ((indexFigura + mov) < 0) return;

            Figura fig = figuras[indexFigura];
            figuras.RemoveAt(indexFigura);

            figuras.Insert(indexFigura + mov, fig);

            control.Refresh();
        }

        public void ForzarRePaint()
        {
            control.Refresh();
        }

        public void Paint()
        {
            foreach (Figura a in figuras)
            {
                if (a.oculto) continue;
                Pen pen = new Pen(a.colorLinea, a.GrosorLinea);

                if (a is LineaRecta)
                {
                    g.DrawLine(pen, a.puntos[0], a.puntos[1]);
                }
                else if (a is LineaCurva)
                {
                    LineaCurva lc = ((LineaCurva)a);
                    if (lc.Cerrada)
                    {
                        if (a.GrosorLinea > 0) g.DrawClosedCurve(pen, a.puntos);
                        if (a.Relleno) g.FillClosedCurve(new SolidBrush(a.ColorRelleno), a.puntos);
                    }
                    else g.DrawCurve(pen, a.puntos);
                }
                else if (a is Elipse)
                {
                    Rectangle rect = new Rectangle(a.x, a.y, a.Ancho, a.Alto);
                    if (a.GrosorLinea > 0) g.DrawEllipse(pen, rect);
                    if (a.Relleno) g.FillEllipse(new SolidBrush(a.ColorRelleno), rect);
                }
                else if (a is Poligono)
                {                    
                    if (a.GrosorLinea > 0) g.DrawPolygon(pen, a.puntos);
                    if (a.Relleno) g.FillPolygon(new SolidBrush(a.ColorRelleno), a.puntos);
                }

            }
            
        }
        #endregion

        #region ToCode
        public String ToCode()
        {
            String Code = "";
            Code += " Pen pen; \n";
            Code += " Point[] puntos; \n";
            Code += "Rectangle rect; \n";

            foreach (Figura a in figuras)
            {

                if (a is LineaRecta)
                {
                    String figRecta = "";
                    figRecta += $" pen = new Pen({newColor(a.colorLinea)}, {a.GrosorLinea}); \n";
                    figRecta += $"g.DrawLine(pen, {a.puntos[0].X}, {a.puntos[0].Y}, {a.puntos[1].X}, {a.puntos[1].Y}); \n";
                    Code += figRecta;
                }

                else if (a is LineaCurva)
                {
                    LineaCurva lc = ((LineaCurva)a);
                    String figCurva = "";
                    figCurva += $" pen = new Pen({newColor(a.colorLinea)}, {a.GrosorLinea}); \n";
                    figCurva += $" puntos = {newPointArr(a.puntos)}; \n";

                    if (lc.Cerrada)
                    {
                        if (a.GrosorLinea > 0) figCurva += $" g.DrawClosedCurve(pen, puntos); \n";
                        if (a.Relleno) figCurva += $" g.FillClosedCurve(new SolidBrush({newColor(a.ColorRelleno)}), puntos); \n";
                    }
                    else figCurva += " g.DrawCurve(pen, a.puntos); \n";

                    Code += figCurva;
                }

                else if(a is Poligono)
                {
                    String figPolig = "";
                    figPolig += $" pen = new Pen({newColor(a.colorLinea)}, {a.GrosorLinea}); \n";
                    figPolig += $" puntos = {newPointArr(a.puntos)}; \n";

                    if (a.GrosorLinea > 0) figPolig += "g.DrawPolygon(pen, puntos); \n";
                    if (a.Relleno) figPolig  += $" g.FillPolygon(new SolidBrush({newColor(a.ColorRelleno)}), puntos); \n";

                    Code += figPolig;
                }

                else if (a is Elipse)
                {
                    String figElipse = "";
                    figElipse += $" pen = new Pen({newColor(a.colorLinea)}, {a.GrosorLinea}); \n";
                    figElipse += $" rect = new Rectangle({a.x}, {a.y}, {a.Ancho}, {a.Alto}); \n";

                    if (a.GrosorLinea > 0) figElipse += " g.DrawEllipse(pen, rect); \n";
                    if (a.Relleno) figElipse += $" g.FillEllipse(new SolidBrush({newColor(a.ColorRelleno)}), rect); \n";

                    Code += figElipse;
                }


                Code += "\n";
            }

            return Code;
        }


        public String newColor(Color color)
        {
            return $" Color.FromArgb({color.R}, {color.G}, {color.B}) ";
        }

        public String newPointArr(Point[] puntos)
        {
            String points = "";
            for (int i = 0; i < puntos.Length; i++)
            {
                points += $"new Point({puntos[i].X}, {puntos[i].Y})";
                if (i != puntos.Length - 1) points += ", \n                     ";
            }
                            
            return " new Point[]{"+points+"}";
        }

        #endregion

        #region Persistencia
        String Ruta = @"..\DibujoBackup.bkp";
        public bool SaveToFile()
        {

            try
            {                
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(Ruta, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                {
                    formatter.Serialize(stream, figuras);
                }
                    
            }
            catch (Exception)
            {
                
                return false;
            }

            return true;

        }

        public bool LoadFromFile()
        {
            try
            {
                if(!File.Exists(Ruta))
                {
                    if (!SaveToFile()) return false;                    
                }

                using (FileStream stream = File.OpenRead(Ruta))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    List<Figura> _figuras = new List<Figura>();

                    _figuras = (List<Figura>)formatter.Deserialize(stream);

                    if (_figuras.Count > 0)
                    {
                        figuras = _figuras;
                    }
                }
                                    

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        #endregion



    }
}
