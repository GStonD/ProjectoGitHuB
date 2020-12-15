using System;
using System.Collections;
using System.Collections.Generic;
using projecto_incidencias.Models;

namespace projecto_incidencias.Models
{
    public class Equipo
    {
        
         public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }    
        public string AULA { get; set; }
        public string AREA { get; set; }
        public string Fecha_adquisicion_hw { get; set; }
        public string garantia { get; set; }
        public string ficha_tecnica_hd { get; set; }
        public int num_provee { get; set; }
        public string licencia_hw { get; set; }
        public string fecha_instalacion_hw { get; set; }
        public string conectividad_red { get; set; }
        public List<Aula> AULAS  { get; set; }


    }
}