
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;
using Tienda.Controllers.Productos;
using Tienda.Models;


namespace Tienda.AzureComics
{

     public class ComicsRepository : IComicsRepository { 

    private readonly string connection;
    private readonly CloudStorageAccount storageAccount;
    private readonly CloudTableClient TablaClient;
    private readonly CloudTableClient TablaClient2;


        private readonly  CloudTable Table;
        private readonly CloudTable Table2;

       static  int contador1 =1;
       static int contador2 = 1;



        public ComicsRepository(string connection)
    {
      this.connection = connection;
storageAccount = CloudStorageAccount.Parse(this.connection);

TablaClient = storageAccount.CreateCloudTableClient();
Table = TablaClient.GetTableReference("Comics");




            TablaClient2 = storageAccount.CreateCloudTableClient();
            Table2 = TablaClient2.GetTableReference("Compras");

        

        }

  

        public async Task<bool> BorrarComic(string codigo)
        {
            var retriveOp = TableOperation.Retrieve<AzureComics>(AzureComics.PARTITIONNAME,codigo);

            var rest = await Table.ExecuteAsync(retriveOp);

            var azProd = (AzureComics)rest.Result;
       if (azProd != null)
       {
           var de10p = TableOperation.Delete(azProd);
           await Table.ExecuteAsync(de10p);
           return true;
       }
       return false;



        }

        public async Task<bool> BorrarCompras(string codigo)
        {
            var retriveOp = TableOperation.Retrieve<AzureCompras>(AzureCompras.PARTITIONNAME, codigo);

            var rest = await Table2.ExecuteAsync(retriveOp);

            var azProd = (AzureCompras)rest.Result;
            if (azProd != null)
            {
                var de10p = TableOperation.Delete(azProd);
                await Table2.ExecuteAsync(de10p);
                return true;
            }
            return false;



        }
        public async Task<bool> Cambiar_Estado(CreateCompra cmd)
        {
            var retriveOp = TableOperation.Retrieve<AzureCompras>(AzureCompras.PARTITIONNAME, cmd.ID);

            var rest = await Table2.ExecuteAsync(retriveOp);

            var azProd = (AzureCompras)rest.Result;
            if (azProd != null)
            {
                azProd.Estado = cmd.Estado;

                var update = TableOperation.Replace(azProd);
                await Table2.ExecuteAsync(update);
                return true;
            }
            return false;



        }

        public async Task<bool> Compras(CreateCompra cmd)
        {
            var Lectura = await LeerCompras();
            if (Lectura.Count() > 0)
            {
                contador2 = Lectura.Count() + 1;
            }
            var ent = new AzureCompras(AzureCompras.PARTITIONNAME,contador2.ToString());
    
              ent.Precio_Venta= cmd.Precio_Venta;
              ent.Total_con_Impuesto= cmd.Total_con_Impuesto;
               ent.Role = cmd.Role;
            TableOperation insertar = TableOperation.Insert(ent);
             var resultado = await Table2.ExecuteAsync(insertar);
            return true;

        }

        public async Task<CreateCompra> ComprasPorID(string id)
        {
            var leerop = TableOperation.Retrieve<AzureCompras>(AzureCompras.PARTITIONNAME, id);
            TableResult retrieveResult = await Table2.ExecuteAsync(leerop);
            if (retrieveResult.Result != null)
            {

                var azProd = (AzureCompras)retrieveResult.Result;
                return new CreateCompra()
                {
                    ID = azProd.ID,

                    Estado = azProd.Estado,
                    Precio_Venta = azProd.Precio_Venta,
                    Total_con_Impuesto = azProd.Total_con_Impuesto,
                     Role = azProd.Role






                };
            }
            else
            {
                return null;
            }

        }

        public async Task<bool> CrearComic(CreateComicCommand cmd)
        {
            var  Lectura =  await LeerComics();
            if (Lectura.Count() > 0)
            {
                contador1 = Lectura.Count() +1;
            } 
           
           var ent = new AzureComics(AzureComics.PARTITIONNAME,contador1.ToString());
           ent.Nombre = cmd.Nombre;
           ent.Descripcion = cmd.Descripcion;
           ent.Categorìa = cmd.Categoria;
           ent.Costo = cmd.Costo;
         
           ent.Numero_de_comic = cmd.Numero_de_comic;
           ent.Fecha_de_Publicaciòn = cmd.Fecha_de_Publicacion;
           TableOperation insertar = TableOperation.Insert(ent);
           var resultado = await Table.ExecuteAsync(insertar);
 

return true;


        }

        public async  Task<List<CreateComicCommand>> LeerComics()
        {

var query = new TableQuery<AzureComics>().Where(
    TableQuery.GenerateFilterCondition("PartitionKey",QueryComparisons.Equal,AzureComics.PARTITIONNAME));
    var tk = new TableContinuationToken();
    var lista = new List<AzureComics>();

foreach (var  entity in await Table.ExecuteQuerySegmentedAsync(query, tk)){

lista.Add(entity);

}


            return lista.Select(e => new CreateComicCommand()
            {

                ID = e.ID,
Nombre = e.Nombre,
Descripcion = e.Descripcion,
Categoria =  e.Categorìa,
Costo = e.Costo,
Numero_de_comic = e.Numero_de_comic,
Fecha_de_Publicacion = e.Fecha_de_Publicaciòn

      }).ToList();




      
    
          
        
        }
        public async Task<List<CreateCompra>> LeerCompras()
        {

            var query = new TableQuery<AzureCompras>().Where(
                TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, AzureCompras.PARTITIONNAME));
            var tk = new TableContinuationToken();
            var lista = new List<AzureCompras>();

            foreach (var entity in await Table2.ExecuteQuerySegmentedAsync(query, tk))
            {

                lista.Add(entity);

            }


            return lista.Select(e => new CreateCompra()
            {

                ID = e.ID,
                Precio_Venta = e.Precio_Venta,
                Total_con_Impuesto = e.Total_con_Impuesto,
                Estado = e.Estado,
                Role = e.Role

           
            
             

            }).ToList();








        }



        public async Task<Model> LeerComicsPorID(string codigo)
        {
                  var leerop = TableOperation.Retrieve<AzureComics>(AzureComics.PARTITIONNAME,codigo);
          TableResult retrieveResult = await Table.ExecuteAsync(leerop);
if  ( retrieveResult.Result  != null   ){

var azProd =(AzureComics)retrieveResult.Result;
return new Model(){
ID = azProd.ID,

Nombre = azProd.Nombre,
Descripcion = azProd.Descripcion,
Categorìa =  azProd.Categorìa,
Costo = azProd.Costo,
Numero_de_comic = azProd.Numero_de_comic,
Fecha_de_Publicaciòn = azProd.Fecha_de_Publicaciòn
};
}else{
return null;
}



        }

        internal class AzureComics : TableEntity{
public AzureComics(){


}
public AzureComics(string partitionKey, string Rowid){

PartitionKey = partitionKey;
RowKey = Rowid;
}

     public string ID { get{return RowKey;} set{RowKey = value;} }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categorìa { get; set; }
        public double Costo { get; set; }
        public int Numero_de_comic { get; set; }
        public string Fecha_de_Publicaciòn { get; set; }
        public const  string  PARTITIONNAME = "Comics";






        }
        internal class AzureCompras: TableEntity
        {
            public AzureCompras()
            {


            }
            public AzureCompras(string partitionKey, string Rowid)
            {

                PartitionKey = partitionKey;
                RowKey = Rowid;
            }

            public string ID { get { return RowKey; } set { RowKey = value; } }
            public string Precio_Venta { get; set; }
            public string Total_con_Impuesto { get; set; }
            public string Estado { get; set; }
            public string Role { get; set; }
            public const string PARTITIONNAME = "Compras";






        }
    }
}
