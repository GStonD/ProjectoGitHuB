using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testx.Models;

namespace testx
{
    public class ContactosRepository : IContactosRepository
    {
        private static List<Contacto> dc;
        static ContactosRepository()
        {
            dc = new List<Contacto>();
            


        }


        public List<Contacto> LeerContactos()
        {

            return dc.ToList();
        }

        public Contacto LeerContactosPorId(int id)
        {
            return dc.FirstOrDefault(t => t.id == id);
        }

        public bool CrearContacto(Contacto model)
        {
            if (dc.Count == 0)
            {
                model.id = 1;
                model.date = DateTime.Today;
            }
            else
            {
                model.id = dc.Max(p => p.id) + 1;
            }
            dc.Add(model);
            return true;
        }

        public  bool ActualizarContactos(Contacto con)
        {
            var t = dc.FirstOrDefault(co => con.id == co.id);
            if (t == null)
            {
                return false;
            }
            t.nombre= con.nombre;
            t.apellido = con.apellido;
            t.correo = con.correo;
            t.date = con.date;
            t.direccion = con.direccion;
            t.id = con.id;
            dc.Remove(t);
            return true;
        }
        public bool BorrarTarea(int id)
        {

            var t = dc.FirstOrDefault(tar => id == tar.id);

            if (t == null)
            {
                return false;
            }
            dc.Remove(t);

            return true;

        }



    }
    
}
