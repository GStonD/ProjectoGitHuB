

using System;
using System.Collections;
using System.Collections.Generic;
using projecto_incidencias.Models;


namespace projecto_incidencias.Models
{
    public class Usuario
    {
         public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        
          public string AREA { get; set; }

          public string PUESTO { get; set; }
          
           public string TIPO { get; set; }

               public List<Aula> go  { get; set; }
}
}