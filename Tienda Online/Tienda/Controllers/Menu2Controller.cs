using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.AzureComics;
using Tienda.Controllers.Productos;

namespace Tienda.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class Menu2Controller : ControllerBase
    {
        private readonly IComicsRepository repo;


        public Menu2Controller(IComicsRepository repo)
        {
            this.repo = repo;
        }

        // GETComics: api/Menu2
        [HttpGet]
        public async  Task<ActionResult<List<CreateComicCommand>>> GetComics()
        {
            var model =    await repo.LeerComics();
            if (model == null)
            {
                return NotFound();
            }
            //return new string[] { "value1", "value2" };
            return model;
        }
        // GETCompras: api/Menu2
      /*  [HttpGet]
        public async Task<ActionResult<List<CreateCompra>>> GetCompras()
        {
            var model = await repo.LeerCompras();
            if (model == null)
            {
                return NotFound();
            }
            //return new string[] { "value1", "value2" };
            return model;
        }

    */
        // GET: api/Menu2/5
       /* [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        */
        // POST: api/Menu2
        [HttpPost]
        public async Task<ActionResult<bool>>PostComics(CreateComicCommand cmd)
        {
            return  await repo.CrearComic(cmd);

        }
         
        // PUT: api/Menu2/5
        /*
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(CreateCompra cmd)
        {
            return  await repo.Cambiar_Estado(cmd);
        }
        */
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(string id)
        {
            return await repo.BorrarComic(id);
        }
    }
}
