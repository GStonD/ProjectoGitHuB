using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Sqlite;
using System.IO;

namespace testx
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            createDB();
            Configuration = configuration;
                }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });
            var dbcon = Configuration.GetValue<String>("dbFilename");
            services.AddTransient<ContactoSQLiteRepository>(s =>
            {
                return new ContactoSQLiteRepository("Filename=app.db");

            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/MenuContacto/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(

                    name: "Index",
                    template: "{controller=MenuContacto}/{action=Index}/{id?}");
                routes.MapRoute(
                  name: "Details",
                  template: "{controller=MenuContacto}/{action=Details}/{id?}");
                routes.MapRoute(
                   name: "Create",
                   template: "{controller=MenuContacto}/{action=Create}/{id?}");
                routes.MapRoute(
                   name: "Delete",
                   template: "{controller=MenuContacto}/{action=Delete}/{id?}");
                routes.MapRoute(
                  name: "Edit",
                  template: "{controller=MenuContacto}/{action=Edit}/{id?}");
                     routes.MapRoute(
                  name: "Create_aula",
                  template: "{controller=MenuContacto}/{action=Create_aula}/{id?}");
                   routes.MapRoute(

                    name: "Index_Usuarios",
                    template: "{controller=MenuContacto}/{action=Index_Usuarios}/{id?}");
                routes.MapRoute(
                name: "Crear_Referenciado",
                template: "{controller=MenuContacto}/{action=Crear_Referenciado}/{id?}");
                routes.MapRoute(
          name: "Detalles_de_Referencias",
          template: "{controller=MenuContacto}/{action=Detalles_de_Referencias}/{id?}");
                routes.MapRoute(
                      name: "Borrar Referencia",
          template: "{controller=MenuContacto}/{action=Borrar_Referencia}/{id?}");
 routes.MapRoute(
                      name: "Puente",
          template: "{controller=MenuContacto}/{action=Puente}/{id?}");
routes.MapRoute(
                      name: "Create_Software",
          template: "{controller=MenuContacto}/{action=Create_Software}/{id?}");
routes.MapRoute(
                      name: "Create_Redes",
          template: "{controller=MenuContacto}/{action=Create_Redes}/{id?}");
          routes.MapRoute(
                      name: "Create_Hardware",
          template: "{controller=MenuContacto}/{action=Create_Hardware}/{id?}");

            routes.MapRoute(
                      name: "Edit_usuario",
          template: "{controller=MenuContacto}/{action=EditUsuario}/{id?}");









        });


        }
       public void createDB()
        {

            using (SqliteConnection db =

               new SqliteConnection("Filename=app.db"))
            {
                db.Open();

                String tableCommand = " CREATE TABLE IF NOT " +
                    "EXISTS ContactoTable ( ID INTEGER   , NOMBRE  varchar(200)  not null  , APELLIDO  varchar(200)  not null  , DIRECCION  varchar(200) not null  , CORREO varchar(200)  not null , TELEFONO int not null , EDAD int not  null, DATE DATETIME  not null , TIPOCONTACTO varchar(200)  not null " +
                    " )";


                SqliteCommand CreateTable = new SqliteCommand(tableCommand, db);
                CreateTable.ExecuteReader();

                 String tableCommand2 = " CREATE TABLE IF NOT " + "EXISTS Referencia (id_ContactoA  int  not null,id_ContactoB int  not null ,nombre_ContactoA varchar(200) not null,nombre_ContactoB varchar(200) not null )";

                SqliteCommand CreateTable2 = new SqliteCommand(tableCommand2, db);
                CreateTable2.ExecuteReader();


                String tableCommand3 = " CREATE TABLE IF NOT " + "EXISTS Usuario (ID INTEGER  not null  ,NOMBRE varchar(200) not null  ,APELLIDO varchar(200) not null  ,AREA varchar(200) not null  ,PUESTO varchar(200) not null  ,tipo varchar(200) not null)";

                SqliteCommand CreateTable3 = new SqliteCommand(tableCommand3, db);
                CreateTable3.ExecuteReader();

                String tableCommand4 = " CREATE TABLE IF NOT " + "EXISTS Aula (ID INTEGER  not null  ,NOMBRE varchar(200) not null  ,AREA varchar(200)   ,DESCRIPCION varchar(200)  )";

                SqliteCommand CreateTable4 = new SqliteCommand(tableCommand4, db);
                CreateTable4.ExecuteReader();

                 String tableCommand5 = " CREATE TABLE IF NOT " + "EXISTS Equipo (ID INTEGER  not null  ,NOMBRE varchar(200) not null  ,Aula varchar(200) not null  ,Area varchar(200) not null  ,Fecha_adquisicion varchar(200)    ,garantia varchar(200)  ,ficha_tecnica varchar(200)  ,num_proveedor INTEGER ,conectividad varchar(200) ,licencia varchar(200) ,tipo varchar(200) )";

                SqliteCommand CreateTable5 = new SqliteCommand(tableCommand5, db);
                CreateTable5.ExecuteReader();
                
                String tableCommand6 = " CREATE TABLE IF NOT " + "EXISTS SERVICIO (ID INTEGER  not null  ,NOMBRE varchar(200) not null  ,NOMBRE_TECNICO varchar(200) not null  ,AREA varchar(200) not null  ,AULA varchar(200) not null  ,EQUIPO varchar(200) not null, FECHA varchar(200) not null ,ESTADO varchar(200) not null ,DESCRIPCION varchar(200) not null ,FECHA_TERMINACION varchar(200) ,CONFIGURACION varchar(200) ,NOMBRE_ID varchar(200) ,NOMBRE_TECNICO_ID varchar(200) ,AULA_ID varchar(200) ,EQUIPO_ID varchar(200))";

                SqliteCommand CreateTable6 = new SqliteCommand(tableCommand6, db);
                CreateTable6.ExecuteReader();



            }

 
            }
        }
    }

