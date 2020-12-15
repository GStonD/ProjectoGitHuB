
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
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data;
using Microsoft.Extensions.Configuration;

using Tienda.Models;
using Tienda.Controllers.Productos;
using Microsoft.AspNetCore.Authorization;



namespace Tienda.Controllers
{
    public class MenuController : Controller
    {

         static int clave_compras = 1;
      static int clave_productos = 1;
   
          repositorio rep = new repositorio();
        IdentityUser user = new IdentityUser();

        private readonly  IComicsRepository repo ;


        public MenuController(IComicsRepository repo)
    {
            this.repo = repo;
        }



        public  async Task<ActionResult> Categories( )
        {
            var comics = await repo.LeerComics();
      
            return View(comics);
        }

        public async Task<ActionResult> Estado(string id)
        {

            var compras = await repo.ComprasPorID(id);
            return View(compras);

           
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Estado_post()
        {
            CreateCompra cmd = new CreateCompra();
            cmd.ID = Request.Form["Estadoid"].ToString();
            cmd.Estado = Request.Form["Seleccione el Estado"].ToString();
          
            await repo.Cambiar_Estado(cmd);

            return RedirectToAction(nameof(Leer_Compras));

        }
        public async Task<ActionResult> Carrito()
        {
           
            var comics = await repo.LeerComics();
            return View(comics);
            
         
        }

        // GET: Actions/Details/5
        public async Task<ActionResult> Details()
        {
                  var comics = await repo.LeerComics();
            return View(comics);


        }
 


        public async Task<ActionResult> Compras()
        {
           /* try
            {
            */


 CreateCompra com = new CreateCompra();
            double suma = 0;
            double impuesto = 0;
            var comics = await repo.LeerComics();

            foreach (var item in comics)
            {
                suma = suma + item.Costo;
            }

            com.Precio_Venta = suma.ToString(); ;
            impuesto = suma * 0.16;
            suma = suma + impuesto;

           
            com.ID = clave_compras.ToString();

            com.Total_con_Impuesto = suma.ToString();

            com.Role = User.Identity.Name.ToString();
            var res = await repo.Compras(com);
            clave_compras++;
            
            foreach (var item in comics)
            {
               await repo.BorrarComic(item.ID); 
            }
          
            clave_productos = 1;
      

            return View(com);


            /*
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Carrito));
            }
        
    */

        }

        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> Leer_Compras()
        {
           var res = await  repo.LeerCompras();

            return View(res);
          
        }
        [Authorize]
        public async Task<ActionResult> Mis_Compras()
        {
            var res = await repo.LeerCompras();

            return View(res);

        }

        /*
        <form asp-action="Pedido_go" method="post" enctype="multipart/form-data">

    <input name = "carrito" type="submit" value="Mis Compras" class="btn btn-default" style="width:200px;height:50px;position:absolute;left:800px;background-color:#FFFF00" />

</form>

    */
        // GET: Actions/Create
    
        public   async Task<ActionResult> Create_Marvel_Products()
        {
            try
            {
  var comics = await repo.LeerComics();
            return View(comics);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Create_Marvel_Products));
            }

          

        }

        public async Task<ActionResult> Create_DC_Products()
        {


            var comics = await repo.LeerComics();
            return View(comics);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult go()
        {
        
            return RedirectToAction(nameof(Carrito));

        }
     [Authorize]
     [HttpPost]
     [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create_Marvel_Products_logica()
        {
            //Model con = new Model();
            //rep.CrearContacto(con);

            try
            {
  CreateComicCommand cmd = new    CreateComicCommand();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Logan"].ToString();
            cmd.Categoria = "Marvel";
            cmd.Fecha_de_Publicacion = "Agosto 2008";
            cmd.Numero_de_comic = 1;
            cmd.Costo = 125;
            var res = await repo.CrearComic(cmd);
                 clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
            }
            catch (Exception)
            {

                return RedirectToAction(nameof(Create_Marvel_Products));
            }
         
        
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
     [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica2()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
       
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Cuatro Fantasticos"].ToString();
             cmd.Categoria="Marvel";
            cmd.Fecha_de_Publicacion = "Noviembre de 1961";
            cmd.Numero_de_comic = 1;
            cmd.Costo = 125;
    
            var res = await repo.CrearComic(cmd);

        clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica3()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Marvel Zombies"].ToString();
             cmd.Categoria="Marvel";
            cmd.Fecha_de_Publicacion = "Diciembre de 2005";
            cmd.Costo = 125;
            cmd.Numero_de_comic = 2;
        
            var res = await repo.CrearComic(cmd);
            rep.CrearContacto(con);
    clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica4()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Venom"].ToString();
          cmd.Categoria="Marvel";
            cmd.Fecha_de_Publicacion = "Noviembre de 2017";
            cmd.Costo = 145;
            cmd.Numero_de_comic = 11;
           
            var res = await repo.CrearComic(cmd);
            rep.CrearContacto(con);
 clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica5()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["X man"].ToString();
           cmd.Categoria="Marvel";
            cmd.Fecha_de_Publicacion = "Septiembre de 1963";
            rep.CrearContacto(con);
            cmd.Costo = 135;
            cmd.Numero_de_comic = 4;
          
            var res = await repo.CrearComic(cmd);
  clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica6()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["The Defenders"].ToString();
            cmd.Categoria="Marvel";
            cmd.Costo = 140;
            cmd.Fecha_de_Publicacion = "Diciembre de 1971 ";
            cmd.Numero_de_comic = 5;
            rep.CrearContacto(con);
          
            var res = await repo.CrearComic(cmd);
  clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica7()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["The SpiderMan"].ToString();
             cmd.Categoria="Marvel";
            cmd.Costo = 125;
            cmd.Fecha_de_Publicacion = "Diciembre de 1963";
            cmd.Numero_de_comic = 12;
            rep.CrearContacto(con);
          
            var res = await repo.CrearComic(cmd);
  clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
    }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica8()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Infinity Gauntlet"].ToString();
          cmd.Categoria="Marvel";
            cmd.Fecha_de_Publicacion = "Julio de 1991";
            cmd.Numero_de_comic = 6;
            cmd.Costo = 150;
            rep.CrearContacto(con);
      
            var res = await repo.CrearComic(cmd);
      clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica9()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Thor/Hulk"].ToString();
             cmd.Categoria="Marvel";
            cmd.Costo = 150;
            cmd.Fecha_de_Publicacion = "Julio de 2006 ";
            cmd.Numero_de_comic = 4;
            rep.CrearContacto(con);

            var res = await repo.CrearComic(cmd);
   clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async  Task<ActionResult> Create_Marvel_Products_logica10()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Civil War 2"].ToString();
          cmd.Categoria="Marvel";
            cmd.Costo = 150;
            cmd.Fecha_de_Publicacion = "Junio de 2016";
            cmd.Numero_de_comic = 2;
            rep.CrearContacto(con);
          
            var res = await repo.CrearComic(cmd);
  clave_productos++;
            return RedirectToAction(nameof(Create_Marvel_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica11()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["Liga de la Justiciawe"].ToString();
            cmd.Categoria="DC";
            cmd.Costo = 120;
            cmd.Fecha_de_Publicacion = "Marzo de 1960";
            cmd.Numero_de_comic = 2;
            rep.CrearContacto(con);
     
            var res = await repo.CrearComic(cmd);
       clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica12()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["hBatman"].ToString();
            cmd.Categoria="DC";
            cmd.Costo = 115;
            cmd.Fecha_de_Publicacion = "marzo de 1939";
            cmd.Numero_de_comic = 27;
            rep.CrearContacto(con);
   
            var res = await repo.CrearComic(cmd);
         clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica13()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
      
            cmd.Nombre = Request.Form["SuperMan"].ToString();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
               cmd.Costo = 122;
           rep.CrearContacto(con);
            cmd.Fecha_de_Publicacion = "marzo de 1938 ";
            cmd.Numero_de_comic = 10;
            var res = await repo.CrearComic(cmd);
            clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica14()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Nombre = Request.Form["SuperGirlc"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 125;
            cmd.Categoria="DC";
            cmd.Fecha_de_Publicacion = "agosto de 1958";
            cmd.Numero_de_comic = 8;
           
            var res = await repo.CrearComic(cmd);
 clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task< ActionResult> Create_Marvel_Products_logica15()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["SuperMan:Doomsdayb"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 125;
            cmd.Fecha_de_Publicacion = "Diciembre de 1992";
            cmd.Numero_de_comic = 7;
           
            var res = await repo.CrearComic(cmd);
 clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica16()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["vTeen Titans"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 125;
           
            cmd.Fecha_de_Publicacion = "Diciembre de 1998";
            cmd.Numero_de_comic = 7;
 var res = await repo.CrearComic(cmd);
            clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica17()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["Flash Pointb"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 150;
            
            cmd.Fecha_de_Publicacion = "Mayo de 2011";
            cmd.Numero_de_comic = 5;
            clave_productos++;
var res = await repo.CrearComic(cmd);
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Create_Marvel_Products_logica18()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["NightWingv"].ToString();
    
            cmd.Costo = 130;
            cmd.Fecha_de_Publicacion = "Julio de 1963";
            cmd.Numero_de_comic = 13;
       
            var res = await repo.CrearComic(cmd);
     clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task< ActionResult> Create_Marvel_Products_logica19()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["AquaManb"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 110;
    cmd.Fecha_de_Publicacion = "Julio de 1941";
  cmd.Numero_de_comic = 15;
            var res = await repo.CrearComic(cmd);   
            clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
[Authorize]
        public async Task< ActionResult> Create_Marvel_Products_logica20()
        {
                CreateComicCommand cmd = new    CreateComicCommand();
            Model con = new Model();
            cmd.ID = clave_productos.ToString();
            cmd.Categoria="DC";
            cmd.Nombre = Request.Form["Green Laternb"].ToString();
            rep.CrearContacto(con);
            cmd.Costo = 140;
            cmd.Fecha_de_Publicacion = "Julio de 1940";
            cmd.Numero_de_comic = 11;
        
            var res = await repo.CrearComic(cmd);
    clave_productos++;
            return RedirectToAction(nameof(Create_DC_Products));
        }



        // GET: Actions/Edit/5
        public ActionResult Edit()
        {
              Model co = new Model();

              
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                 Model co = new Model();

                   co.Nombre  = Request.Form["botonlogan"].ToString();

                return RedirectToAction(nameof(Create_Marvel_Products));
            }
            catch
            {
                return View();
            }
        }


      

        // POST: Actions/Delete/5
        
        public  async Task <ActionResult> Delete(string id)
        {
            var res = await repo.BorrarComic(id);
 

            return RedirectToAction(nameof(Carrito));
              
          

                
            
        }
        public async Task<ActionResult> DeleteCompras(string id)
        {
            var res = await repo.BorrarCompras(id);


            return RedirectToAction(nameof(Leer_Compras));





        }

        [HttpPost]
        [ValidateAntiForgeryToken]
          public  ActionResult Totalizar()
        {
                return RedirectToAction(nameof(Compras));
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pedido_go()
        {
            return RedirectToAction(nameof(Mis_Compras));

        }


    }
}