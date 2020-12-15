using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tienda.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tienda.Controllers.Productos;
using Tienda.Models;
using Tienda;
using Tienda.AzureComics;

namespace Tienda
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
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
         


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
                    
                 
 services.AddTransient<IComicsRepository>(o => new ComicsRepository("DefaultEndpointsProtocol=https;AccountName=s101moyag5;AccountKey=DE12s3D5uq5R3GFqaPwinz5N4uZN2e8KB4CHV0fBUXCpb0uQU4Jxh19OYtqoQDzYFG5OMKStfXV6Aqee8POp7A=="));
   //services.AddDefaultIdentity<IdentityUser>() 
   services
                .AddIdentity<IdentityUser , IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();
                 

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);




           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env , UserManager<IdentityUser> uManager , RoleManager<IdentityRole> rManager)
        {
            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

          //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Menu}/{action=Categories}/{id?}");
            });
            InitIdentity(uManager, rManager);
           
        }

        public void  InitIdentity(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var adminRole = new IdentityRole("Admin");

                var res = roleManager.CreateAsync(adminRole);
            }





                if(userManager.FindByEmailAsync("admin@mail.com").Result == null)
            {

                    IdentityUser user = new IdentityUser
                    {

                        UserName = "admin@mail.com",
                        Email = "admin@mail.com"



                    };
                
                    IdentityResult result = userManager.CreateAsync(user, "Goku1737+").Result;


                    if (result.Succeeded)
                    {

                        userManager.AddToRoleAsync(user, "Admin").Wait();


                    }


                }

            }


        }






/*
        public void InitIdentity(UserManager<IdentityUser> userManager, RoleManager<IdentityUser> roleManager)
        {

            if(userManager.FindByEmailAsync("admin@hotmail.com").Result == null)
            {

                IdentityUser user = new IdentityUser
                {

                    UserName = "admin@hotmail.com",
                    Email = "admin@hotmail.com"



                };
                IdentityResult result = userManager.CreateAsync(user, "Goku1737").Result;


                if (result.Succeeded)
                {


                    userManager.AddToRoleAsync(user, "Admin").Wait();





               }
                    




            }

        }

*/ 








        }
            
    

