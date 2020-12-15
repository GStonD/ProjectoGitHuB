using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testx.Models
{
    public class Contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }
        public DateTime date { get; set; }
        public string foto { get; set; }
        public string tipocontacto { get; set; }
        public List<Referencia> Refe { get; set; } = new List<Referencia>();
}
}
