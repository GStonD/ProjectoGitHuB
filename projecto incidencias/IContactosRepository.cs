using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testx.Models;

namespace testx { 



   public  interface IContactosRepository
    {
        List<Contacto> LeerContactos();
        Contacto LeerContactosPorId(int id);
        bool CrearContacto(Contacto model);
        bool ActualizarContactos(Contacto con);
        bool BorrarTarea(int id);
     




    }
}
