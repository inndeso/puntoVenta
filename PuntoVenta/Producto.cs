using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PuntoVenta
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Codigo { get; set; }

        public BitmapImage Imagen { get; set; }

    }
}
