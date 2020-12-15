
using System;
using System.Collections;
using System.Collections.Generic;
using projecto_incidencias.Models;
namespace projecto_incidencias.Models
{
    public class Aula
    {
         
         public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string AREA { get; set; }    
        public string DESCRIPCION { get; set; }

        public List<Usuario> go  { get; set; }
    }
}