using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testx.Models
{
    public class Referencia

    {
        public int id { get; set; } = 0;
    
       public int id_ContactoA { get; set; }
        public int id_ContactoB { get; set; }
        public string nombre_ContactoA { get; set; }
        public string nombre_ContactoB { get; set; }
        public string Relacion { get; set; }
    }
}
