using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Models
{
    public class Model
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categorìa { get; set; }
        public double Costo { get; set; }
        public double Precio_Venta { get; set; }
        public double Impuesto { get; set; }
        public int Numero_de_comic { get; set; }
        public string Fecha_de_Publicaciòn { get; set; }
    }
}
