using System.Collections.Generic;
using Tienda.Models;
using System.Threading.Tasks;
using System;

namespace Tienda.Controllers.Productos
{
    public interface IComicsRepository
    {

        Task<List<CreateComicCommand>> LeerComics();
        Task<bool> BorrarComic(string codigo);
        Task<bool> BorrarCompras(string codigo);
        Task<bool> CrearComic(CreateComicCommand cmd);
        Task<bool> Compras(CreateCompra cmd);
        Task<bool> Cambiar_Estado(CreateCompra cmd);
        Task<CreateCompra> ComprasPorID(string id);
        Task<Model> LeerComicsPorID (string codigo);
        Task<List<CreateCompra>> LeerCompras();
 
    }
    
    public class CreateComicCommand
    {

     public string ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double Costo { get; set; }
      
        public int Numero_de_comic { get; set; }
        public string Fecha_de_Publicacion { get; set; }
     

}



    public class CreateCompra{
        public string ID { get; set; }
        public string Precio_Venta { get; set; }
        public string Total_con_Impuesto { get; set; }
        public string Estado { get; set; }
        public string Role { get; set; }



    }
}