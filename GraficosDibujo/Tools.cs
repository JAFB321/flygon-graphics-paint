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
    public partial class Tools : Form
    {
        #region Componentes
        DibujadorGraficos graficos;
        Main form;

        string RutaImagenFondo =  @"..\..\images\MegaFlygonKudjulu.jpg";

        bool FiguraLista = true;
        #endregion

        #region Constructor
        public Tools(DibujadorGraficos graficos, Main form)
        {
            InitializeComponent();
            this.graficos = graficos;
            this.form = form;

            numericAlto.Maximum = form.Height;
            numericAncho.Maximum = form.Width;
            numericX.Maximum = form.Width;
            numericY.Maximum = form.Width;

            RefreshList();
        }
        #endregion


        #region Botones Figuras
        private void btnLinea_Click(object sender, EventArgs e)
        {
            form.ActivarDibujarFigura(Figuras.LineaRecta);
            ReiniciarValores();
        }

        private void btnCurva_Click(object sender, EventArgs e)
        {
            form.ActivarDibujarFigura(Figuras.LineaCurva);
            ReiniciarValores();
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            form.ActivarDibujarFigura(Figuras.Eliplse);
            ReiniciarValores();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            form.ActivarDibujarFigura(Figuras.Poligono);
            ReiniciarValores();
        }
        #endregion

        #region Propiedades
        public Figura _figura = null;
        public Figura figura
        {
            get { return _figura; }
            set
            {
                _figura = value;
                AgregarFigura(value);
            }
        }



        bool bloqueado = false;
        public bool Bloqueado
        {
            get { return bloqueado; }
            set
            {
                foreach(Control a in this.Controls)
                {
                    a.Enabled = !value;
                }
                bloqueado = value;
            }
        }


        #endregion

        #region Metodos
        public void ActualizarFigura()
        {
            if(_figura is LineaRecta)
            {
                _figura.colorLinea = colorLinea.Color;
                _figura.GrosorLinea = Convert.ToInt32(numericGrosor.Value);
            }

            else if (_figura is LineaCurva)
            {
                LineaCurva lc = (LineaCurva)_figura;
                lc.ColorRelleno = colorRelleno.Color;
                lc.colorLinea = colorLinea.Color;
                lc.GrosorLinea = Convert.ToInt32(numericGrosor.Value);
                lc.Relleno = chkRelleno.Checked;
                lc.Cerrada = chkCerrada.Checked;
            }

            else if (_figura is Poligono)
            {
                _figura.colorLinea = colorLinea.Color;
                _figura.GrosorLinea = Convert.ToInt32(numericGrosor.Value);
                _figura.Relleno = chkRelleno.Checked;
                _figura.ColorRelleno = colorRelleno.Color;
            }

            else if ( _figura is Elipse)
            {
                _figura.colorLinea = colorLinea.Color;
                _figura.GrosorLinea = Convert.ToInt32(numericGrosor.Value);
                _figura.Relleno = chkRelleno.Checked;
                _figura.x = Convert.ToInt32(numericX.Value);
                _figura.y = Convert.ToInt32(numericY.Value);
                _figura.Ancho = Convert.ToInt32(numericAncho.Value);
                _figura.Alto = Convert.ToInt32(numericAlto.Value);
                _figura.ColorRelleno = colorRelleno.Color;
            }

            graficos.ForzarRePaint();
            CodeToClipBoard();
            RefreshList();
        }

        private void AgregarFigura(Figura figura)
        {
            graficos.AgregarFigura(figura);
            AsignarValoresFiguraActual();
            BloquearControles();
            RefreshList();
        }

        public void EliminarUltimaFigura()
        {
            graficos.EliminarUltima();

            AsignarUltimaFigura();

            CodeToClipBoard();
            RefreshList();
        }

        public void EliminarFigura(int index)
        {
            graficos.EliminarFigura(index);

            AsignarUltimaFigura();

            CodeToClipBoard();
            RefreshList();
        }

        public void AsignarUltimaFigura()
        {
            _figura = null;
            _figura = graficos.UltimaFigura;
            AsignarValoresFiguraActual();
            BloquearControles();
        }

        public void BloquearControles()
        {
            if (_figura == null) return;

            if(_figura is LineaRecta)
            {
                BoundsPanel.Enabled = false;
                chkRelleno.Enabled = false;
                chkCerrada.Enabled = false;
                numericGrosor.Enabled = true;
                btnColorLinea.Enabled = true;
                numericY.Enabled = false;
                numericX.Enabled = false;
                numericAlto.Enabled = false;
                numericAncho.Enabled = false;
            }
            else if (_figura is LineaCurva)
            {
                BoundsPanel.Enabled = false;
                chkRelleno.Enabled = chkCerrada.Checked;
                chkCerrada.Enabled = true;
                numericGrosor.Enabled = true;
                btnColorLinea.Enabled = true;
                numericY.Enabled = false;
                numericX.Enabled = false;
                numericAlto.Enabled = false;
                numericAncho.Enabled = false;
            }
            else if (_figura is Elipse)
            {
                BoundsPanel.Enabled = true;
                chkRelleno.Enabled = true;
                chkCerrada.Enabled = false;
                numericGrosor.Enabled = true;
                btnColorLinea.Enabled = true;
                numericY.Enabled = true;
                numericX.Enabled = true;
                numericAlto.Enabled = true;
                numericAncho.Enabled = true;
            }

            else if(_figura is Poligono)
            {
                BoundsPanel.Enabled = false;
                chkRelleno.Enabled = true;
                chkCerrada.Enabled = false;
                numericGrosor.Enabled = true;
                btnColorLinea.Enabled = true;
                numericY.Enabled = false;
                numericX.Enabled = false;
                numericAlto.Enabled = false;
                numericAncho.Enabled = false;
            }

            if (graficos.figuras.Count == 0) btnRegresar.Enabled = false;
            else btnRegresar.Enabled = true;

        }

        public void ReiniciarValores()
        {
            _figura = null;
            colorLinea.Color = Color.Black;
            numericGrosor.Value = 1;
            numericAlto.Value = 0;
            numericAncho.Value = 0;
            numericX.Value = 0;
            numericY.Value = 0;
            chkCerrada.Checked = false;
            chkRelleno.Checked = false;
        }

        public void AsignarValoresFiguraActual()
        {
            if (_figura == null)
            {
                ReiniciarValores();
                return;
            }


            FiguraLista = false;
                colorLinea.Color = _figura.colorLinea;
                numericGrosor.Value = _figura.GrosorLinea;
                numericAlto.Value = _figura.Alto;
                numericAncho.Value = _figura.Ancho;
                numericX.Value = _figura.x;
                numericY.Value = _figura.y;
                if (_figura is LineaCurva) chkCerrada.Checked = ((LineaCurva)_figura).Cerrada;
                else chkCerrada.Checked = false;
                chkRelleno.Checked = _figura.Relleno;

                FiguraLista = true;
            



        }

        public void CodeToClipBoard()
        {
            Clipboard.Clear();
            Clipboard.SetText(graficos.ToCode());
        }

        public Color MostrarColorPicker()
        {
            Color a = ColorPicker.ShowDialog(RutaImagenFondo);
            form.Focus();            
            return a;
        }

        public void CambiarOcultoFigura(int index)
        {
            graficos.CambiarOcultoFigura(index);
            RefreshList();
            
        }

        #region Lista de figuras
        public void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Figura a in graficos.figuras)
            {
                ListViewItem item = new ListViewItem(a.ToString());
                item.UseItemStyleForSubItems = false;

                item.SubItems.Add(a.colorLinea.Name);
                item.SubItems[1].ForeColor = a.colorLinea;

                item.SubItems.Add(a.ColorRelleno.Name);
                item.SubItems[2].ForeColor = a.ColorRelleno;
                
                if(a.oculto)
                {
                    item.UseItemStyleForSubItems = true;
                    item.ForeColor = Color.Gray;
                }

                item.Tag = a;
                listView1.Items.Add(item);
            }
        }

        public void SubirElemento(int indexFig)
        {
            graficos.MoverCapaFigura(indexFig, 1);
            AsignarUltimaFigura();
            RefreshList();
        }

        public void BajarElemento(int indexFig)
        {
            graficos.MoverCapaFigura(indexFig, -1);
            AsignarUltimaFigura();
            RefreshList();
        }

        #endregion

        #endregion

        #region Eventos 
        private void numericGrosor_ValueChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void btnColorLinea_Click(object sender, EventArgs e)
        {
            colorLinea.Color = MostrarColorPicker();
            ActualizarFigura();
        }

        private void chkCerrada_CheckedChanged(object sender, EventArgs e)
        {                
            if(_figura is LineaCurva)chkRelleno.Enabled = chkCerrada.Checked;
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void numericAncho_ValueChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void numericAlto_ValueChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;
            ActualizarFigura();
        }

        private void chkRelleno_CheckedChanged(object sender, EventArgs e)
        {
            if (!FiguraLista) return;            
            if(_figura != null && chkRelleno.Checked)
            {
                colorRelleno.Color = MostrarColorPicker();
            }
            
            ActualizarFigura();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            if (graficos.UltimaFigura == null) return;
                EliminarUltimaFigura();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (graficos.SaveToFile())
            {
                MessageBox.Show("guardado correctamente");
            }

            else MessageBox.Show("error");
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (graficos.LoadFromFile())
            {
                AsignarUltimaFigura();
                RefreshList();
                graficos.ForzarRePaint();
                MessageBox.Show("cargado correctamente");
            }
            else MessageBox.Show("error");
           
        }


        private void btnSubir_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {
                SubirElemento(listView1.SelectedIndices[0]);
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                BajarElemento(listView1.SelectedIndices[0]);
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                CambiarOcultoFigura(listView1.SelectedIndices[0]);
            }
        }
        #endregion

        private void btnListaFigs_Click(object sender, EventArgs e)
        {

        }


    }


    public static class ColorPicker
    {
        public static Color ShowDialog(String rutaImagen)
        {
            ImagenColorPicker form = new ImagenColorPicker(rutaImagen);
            form.ShowDialog();
            return form.ColorPicked;
        }
    }


}
