using System;
using System.Collections.Generic;
using System.Linq;


namespace Tienda.Models
{
    public class repositorio
    {
       private static List<Model> arr;


       static  repositorio()
        {

            arr = new List<Model>();


        }

        public List<Model>mostrar()
        {


            return arr.ToList();


        }
     


            public bool CrearContacto(Model model)
            {
                if (arr.Count == 0)
                {
                model.ID = "1";
                 
                }
                else
                {
                    model.ID = arr.Max(p => p.ID) + 1;
                }
                arr.Add(model);
                return true;
            
        }

        public bool  borrar(string ID)
        {
            var t = arr.FirstOrDefault(tar => ID == tar.ID);

            if (t == null)
            {
                return false;
            }
            arr.Remove(t);

            return true;



        }

    }

}
    