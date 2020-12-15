using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using System.Diagnostics;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using testx.Models;
using System.Web;
using System.IO;
using Microsoft.Data;
using Microsoft.Extensions.Configuration;
using projecto_incidencias.Models;

namespace testx.Controllers
{


    public class MenuContactoController : Controller
    {



        List<Contacto> fot;
List<Servicio> fot2 ;




        public string FotoDir;

        int ID;
        Contacto ccv;

        ContactoSQLiteRepository repo;



        public MenuContactoController(ContactoSQLiteRepository conrepo, IConfiguration config)
        {

            repo = conrepo;
            //Url = url;
            FotoDir = config.GetValue<string>("ContactoSQLiteRepository:imgfolder");


        }



        // GET: MenuContacto

        public ActionResult Index()
        {
            var model = repo.LeerServicios();
            
            return View(model);

        }
         public ActionResult Index_Cambios()
        {

            var model = repo.LeerServicios();
            
            
            return View(model);

        }
public ActionResult Index_Usuarios()
        {
            var model = repo.LeerUsuarios();
            return View(model);

        }
        
        public ActionResult Index_Areas()
        {
            var model = repo.LeerAula();
            return View(model);

        }
         public ActionResult Index_equipo()
        {
            var model = repo.LeerEquipo();
            return View(model);

        }

         public ActionResult Puente()
        {
            var model = repo.LeerContactos();
            return View(model);

        }

        // GET: MenuContacto/Details/5
        public ActionResult Detalles_de_Referencias(int id)
        {
            ID = id;

            var model = repo.LeerReferencias(ID);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);




        }

        
        public ActionResult Detalles_Usuarios(int id)
        {
            ID = id;

            var model = repo.LeerUsuariosPorId(ID);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);




        }
         public ActionResult Detalles_Aula(int id)
        {
            ID = id;

            var model = repo.LeerAulasPorId(ID);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);




        }
           public ActionResult Detalles_Equipo(int id)
        {
            ID = id;

            var model = repo.LeerEquipoPorId(ID);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);




        }

        // GET: MenuContacto/Create
        public ActionResult Create()
        {
            var model = new Usuario();
         
            return View(model);
        }

        // POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario model)
        {
            try
            {

           foreach (var item in repo.LeerUsuarios())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create));
               }
           }

            var resultado = repo.CrearUsuario(model);
            return RedirectToAction(nameof(Index));




            }
            catch (Exception)
            {


            }
           
            // TODO: Add insert logic here



            return RedirectToAction(nameof(Index));
        }



 public ActionResult Create_aula()
        {
            var model = new Aula();
       
            return View(model);
        }

// POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_aula(Aula model)
        {
            try
            {

             foreach (var item in repo.LeerAula())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_aula));
               }
           }

 var resultado = repo.CrearAula(model);
            return RedirectToAction(nameof(Index));




            }
            catch (Exception)
            {


            }
           
            // TODO: Add insert logic here



            return RedirectToAction(nameof(Index));
        }
        public ActionResult Create_Servicio()
        {
            var model = new Servicio();
            model.AULAS = repo.LeerAula();
            model.Equipo = repo.LeerEquipo();
            model.USUARIOS =repo.LeerUsuarios();
       
            return View(model);
        }

// POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_Servicio(Servicio model)
        {
          int a  = Convert.ToInt32(Request.Form["NOMBRE_ID"]);
          int b  = Convert.ToInt32(Request.Form["NOMBRE_TECNICO_ID"]);
           int c = Convert.ToInt32(Request.Form["AULA_ID"]);
           int d = Convert.ToInt32(Request.Form["EQUIPO_ID"]);


if (model.ESTADO == "TERMINADO")
{

   foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_ID)
         {
            model.NOMBRE = item.NOMBRE;
         }
     }
        foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_TECNICO_ID)
         {
           model.NOMBRE_TECNICO = item.NOMBRE;
         }
     }
         foreach (var item in repo.LeerEquipo())
     {
         if (item.ID == model.EQUIPO_ID)
         {
            model.EQUIPO = item.NOMBRE;
         }
     }
          foreach (var item in repo.LeerAula())
     {
         if (item.ID == model.AULA_ID)
         {
           model.AULA = item.NOMBRE;
         }
     }
 foreach (var item in repo.LeerServicios())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_Servicio));
               }
           } 

   

}else{

    
            model.FECHA_TERMINACION = ".";
            model.CONFIGURACION = ".";
         


foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_ID)
         {
            model.NOMBRE = item.NOMBRE;
         }
     }
        foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_TECNICO_ID)
         {
           model.NOMBRE_TECNICO = item.NOMBRE;
         }
     }
         foreach (var item in repo.LeerEquipo())
     {
         if (item.ID == model.EQUIPO_ID)
         {
            model.EQUIPO = item.NOMBRE;
         }
     }
          foreach (var item in repo.LeerAula())
     {
         if (item.ID == model.AULA_ID)
         {
           model.AULA = item.NOMBRE;
         }
     }
 foreach (var item in repo.LeerServicios())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_Servicio));
               }
           }
}

fot2 = new List<Servicio>();

            
 fot2.Add(model);
 var resultado = repo.CrearServicio(model);
            return RedirectToAction(nameof(Index));




          
           
            // TODO: Add insert logic here



        }



         public ActionResult Create_Software()
        {
            var model = new Equipo();
          model.AULAS = repo.LeerAula();
            return View(model);
        }

// POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_Software(Equipo model)
        {
            try
            {

            
                   model.TIPO = "Software";
                   model.conectividad_red = ".";
                    foreach (var item in repo.LeerEquipo())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_Software));
               }
           }
  var resultado = repo.CrearEquipoHW(model);
            return RedirectToAction(nameof(Index));




           

            
           
            // TODO: Add insert logic here


            }
            catch (Exception)
            {


            }
           
            // TODO: Add insert logic here



            return RedirectToAction(nameof(Index));
        

           
        }
 public ActionResult Create_Redes()
        {
            var model = new Equipo();
            model.AULAS = repo.LeerAula();
            return View(model);
        }

// POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_Redes(Equipo model)
        {
            try
            {

             model.TIPO = "Redes";
               model.licencia_hw = ".";

 foreach (var item in repo.LeerEquipo())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_Redes));
               }
           }
  var resultado = repo.CrearEquipoRed(model);
            return RedirectToAction(nameof(Index));




            }
            catch (Exception)
            {


            }
           
            // TODO: Add insert logic here



            return RedirectToAction(nameof(Index));
        }
         public ActionResult Create_Hardware()
        {
            var model = new Equipo();
             model.AULAS = repo.LeerAula(); 
            return View(model);
        }

// POST: MenuContacto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_Hardware(Equipo model)
        {
            try
            {

             model.TIPO = "Hardware";
                        model.conectividad_red = ".";
                   model.licencia_hw = ".";
                    foreach (var item in repo.LeerEquipo())
           {
               if (item.ID == model.ID)
               {
                   return RedirectToAction(nameof(Create_Hardware));
               }
           }

   var resultado = repo.CrearEquipoHD(model);
            return RedirectToAction(nameof(Index));




            }
            catch (Exception)
            {


            }
           
            // TODO: Add insert logic here



            return RedirectToAction(nameof(Index));
        }
        public ActionResult Borrar_Referencia(int id)
        {
            ID = id;

            var model = repo.LeerReferencias(id);

        

            return View(model);



        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logica3()
        {


            var model2 = repo.LeerReferenciasPorId(Convert.ToInt32(Request.Form["Seleccione la referencia"]));
   
            repo.BorrarReferenciaA(Convert.ToInt32(Request.Form["Seleccione la referencia"]),model2.id_ContactoB);
            repo.BorrarReferenciaB(Convert.ToInt32(Request.Form["Seleccione la referencia"]), model2.id_ContactoB);

           
          






            return RedirectToAction(nameof(Index));

        }


      

    

   
      

        // GET: MenuContacto/Edit/5
  

          public ActionResult Delete_usuario( int id)
        {
            ID = id;
            var model = repo.LeerUsuariosPorId(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: MenuContacto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_usuario(int id, IFormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
              var resultado = repo.BorrarUsuario(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
         public ActionResult Delete_aula( int id)
        {
            ID = id;
            var model = repo.LeerAulasPorId(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: MenuContacto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_aula(int id, IFormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
              var resultado = repo.BorrarAula(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
         public ActionResult Delete_servicio( int id)
        {
            ID = id;
            var model = repo.LeerServiciosPorId(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: MenuContacto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_servicio(int id, IFormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
              var resultado = repo.BorrarServicio(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
         public ActionResult Delete_Equipo( int id)
        {
            ID = id;
            var model = repo.LeerEquipoPorId(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: MenuContacto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_Equipo(int id, IFormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
              var resultado = repo.BorrarEquipo(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       



 public ActionResult Edit_usuario(int  id)
        {
            ID = id;
            var model = repo.LeerUsuariosPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }

        // POST: MenuContacto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_usuario(Usuario model)
        {
           
            try
            { 
               
                Usuario contacto = new Usuario();

                // TODO: Add update logic here
        
                contacto.NOMBRE= model.NOMBRE;
                contacto.APELLIDO = model.APELLIDO;
                contacto.PUESTO = model.PUESTO;
                contacto.AREA= model.AREA;
                contacto.TIPO = model.TIPO;
            

                var resultado = repo.ActualizarUsuario(contacto,model.ID);

                return RedirectToAction(nameof(Index));
              }
            catch
            {
                return View(model);
            }
              
           
        }

        public ActionResult Edit_Aula(int  id)
        {
            ID = id;
            var model = repo.LeerAulasPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Aula(Aula model)
        {
            try
            {
                Aula contacto = new Aula();

                // TODO: Add update logic here
        
              
                contacto.NOMBRE= model.NOMBRE;
                contacto.DESCRIPCION = model.DESCRIPCION;
                contacto.AREA = model.AREA;
         
             

                var resultado = repo.ActualizarAula(contacto,model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
          public ActionResult Edit_Equipo_sw(int  id)
        {
            ID = id;
            var model = repo.LeerEquipoPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }
    
         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Equipo_sw(Equipo model)
        {
            try
            {
                Equipo contacto = new Equipo();

                // TODO: Add update logic here
        
              
                contacto.NOMBRE= model.NOMBRE;
                contacto.AREA = model.AREA;
                contacto.AULA = model.AULA;
                contacto.TIPO= model.TIPO;
                contacto.Fecha_adquisicion_hw = model.Fecha_adquisicion_hw;
                contacto.licencia_hw = model.licencia_hw;
                contacto.num_provee = model.num_provee;
                contacto.garantia = model.garantia;
                contacto.ficha_tecnica_hd = model.ficha_tecnica_hd;
                

                var resultado = repo.ActualizarEquipo_hw(contacto,model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }


         public ActionResult Edit_Equipo_hd(int  id)
        {
            ID = id;
            var model = repo.LeerEquipoPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }
          [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Equipo_hd(Equipo model)
        {
            try
            {
            
                Equipo contacto = new Equipo();

                // TODO: Add update logic here
        
              
                contacto.NOMBRE= model.NOMBRE;
                contacto.AREA = model.AREA;
                contacto.AULA = model.AULA;
                 contacto.Fecha_adquisicion_hw = model.Fecha_adquisicion_hw;
                contacto.ficha_tecnica_hd = model.ficha_tecnica_hd;
                contacto.num_provee = model.num_provee;
                contacto.garantia = model.garantia;
                

                var resultado = repo.ActualizarEquipo_hd(contacto,model.ID);

                return RedirectToAction(nameof(Index));
                  }
            catch
            {
                return View(model);
            }
            
        }
          public ActionResult Edit_Equipo_red(int  id)
        {
            ID = id;
            var model = repo.LeerEquipoPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }


            return View(model);
        }
          [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Edit_Equipo_red(Equipo model)
        {
            try
            {
                Equipo contacto = new Equipo();

                // TODO: Add update logic here
        
              
                contacto.NOMBRE= model.NOMBRE;
                contacto.AREA = model.AREA;
                contacto.AULA = model.AULA;
                contacto.TIPO= model.TIPO;
                 contacto.Fecha_adquisicion_hw = model.Fecha_adquisicion_hw;
                contacto.conectividad_red = model.conectividad_red;
                contacto.num_provee = model.num_provee;
                contacto.garantia = model.garantia;
                contacto.ficha_tecnica_hd = model.ficha_tecnica_hd;


                

                var resultado = repo.ActualizarEquipo_red(contacto,model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
      
          public ActionResult Edit_Servicio(int  id)
        {
            ID = id;
                    var model = repo.LeerServiciosPorId(id);
            
            if (model == null)
            {
                return NotFound();
            }

  model.AULAS = repo.LeerAula();
            model.Equipo = repo.LeerEquipo();
            model.USUARIOS =repo.LeerUsuarios();
            return View(model);
        }
          [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Edit_Servicio(Servicio model)
        {
            try
            {
                Servicio contacto = new Servicio();

                // TODO: Add update logic here
        

             
               
                contacto.AREA = model.AREA;
    
                 
                contacto.FECHA = model.FECHA;
                contacto.ESTADO = model.ESTADO;
                contacto.DESCRIPCION = model.DESCRIPCION;
             
            model.CONFIGURACION = ".";
            model.FECHA_TERMINACION = ".";

foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_ID)
         {
            model.NOMBRE = item.NOMBRE;
            contacto.NOMBRE= model.NOMBRE;
         }
     }
        foreach (var item in repo.LeerUsuarios())
     {
         if (item.ID == model.NOMBRE_TECNICO_ID)
         {
           model.NOMBRE_TECNICO = item.NOMBRE;
            contacto.NOMBRE_TECNICO= model.NOMBRE_TECNICO;
         }
     }
         foreach (var item in repo.LeerEquipo())
     {
         if (item.ID == model.EQUIPO_ID)
         {
            model.EQUIPO = item.NOMBRE;
            contacto.EQUIPO = model.EQUIPO;
         }
     }
          foreach (var item in repo.LeerAula())
     {
         if (item.ID == model.AULA_ID)
         {
           model.AULA = item.NOMBRE;
           contacto.AULA= model.AULA;

         }
     }

                

                var resultado = repo.ActualizarServicio(contacto,model.ID);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }


    }
}