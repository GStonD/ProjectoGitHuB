using System;
using System.Collections.Generic;

namespace projecto_incidencias.Models

{
    public class Servicio
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public int NOMBRE_ID { get; set; }
        public string NOMBRE_TECNICO { get; set; }
         public int NOMBRE_TECNICO_ID { get; set; }
        public string AREA { get; set; }    
        public string AULA { get; set; }
         public int AULA_ID { get; set; }
        public string EQUIPO { get; set; }
         public int EQUIPO_ID { get; set; }
        public string FECHA { get; set; }
        public string ESTADO { get; set; }
        public string DESCRIPCION { get; set; }
        public string FECHA_TERMINACION { get; set; }
        public string CONFIGURACION { get; set; }




        public List<Usuario> USUARIOS  { get; set; }
        public List<Aula> AULAS  { get; set; }
        public List<Equipo> Equipo  { get; set; }

    }
}