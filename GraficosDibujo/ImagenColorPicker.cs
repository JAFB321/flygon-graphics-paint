using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosDibujo
{
    public partial class ImagenColorPicker : Form
    {
        Bitmap imagen;
        public Color ColorPicked;


        public ImagenColorPicker(String Ruta)
        {
            InitializeComponent();
            imagen = new Bitmap(Ruta);
           // imagen = ResizeImage(imagen, (int)(imagen.Height*1.7),(int)(imagen.Width * 1.7));

            this.BackgroundImage = imagen;

            this.MouseClick += ImagenColorPicker_MouseClick;
        }

        private void ImagenColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
           ColorPicked = imagen.GetPixel(e.X, e.Y);
           Close();
            Dispose();
        }

        public Bitmap ResizeImage(Image Imagen, int Height, int Width)
        {

            if (Imagen.Size.Width == Width && Imagen.Size.Height == Height) return (Bitmap)Imagen;

            Rectangle destRect = new Rectangle(0, 0, Width, Height);
            Bitmap destImagen = new Bitmap(Width, Height);

            destImagen.SetResolution(Imagen.HorizontalResolution, Imagen.VerticalResolution);

            using (Graphics g = Graphics.FromImage(destImagen))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes warpMode = new ImageAttributes())
                {
                    warpMode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(Imagen, destRect, 0, 0, Imagen.Width, Imagen.Height, GraphicsUnit.Pixel, warpMode);
                }
            }

            return destImagen;
        }
    }
}
