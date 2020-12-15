using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testx.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using projecto_incidencias.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.Sqlite;



namespace testx
{
    public class ContactoSQLiteRepository
    {
        public readonly string connection;


        public ContactoSQLiteRepository(string Connstr)
        {
            connection = Connstr;


        }
        public bool ActualizarContactos(Contacto co)
        {
            var cmd = new SqliteCommand("UPDATE ContactoTable SET " + " ID  = @id , NOMBRE = @nombre, " +
                "APELLIDO =  @apellido ,DIRECCION = @direccion,CORREO = @correo ," +
                "TELEFONO = @telefono, EDAD = @edad ,DATE = @date,TIPOCONTACTO = @tipo");
            cmd.Parameters.AddWithValue("@id", co.id);
            cmd.Parameters.AddWithValue("@nombre", co.nombre);
            cmd.Parameters.AddWithValue("@apellido", co.apellido);
            cmd.Parameters.AddWithValue("@direccion", co.direccion);
            cmd.Parameters.AddWithValue("@correo", co.correo);
            cmd.Parameters.AddWithValue("@telefono", co.telefono);
            cmd.Parameters.AddWithValue("@edad", co.edad);
            cmd.Parameters.AddWithValue("@date", co.date);
            cmd.Parameters.AddWithValue("@tipo", co.tipocontacto);
            executeCMD(cmd);
            return true;
        }
         public bool ActualizarUsuario(Usuario co,int id)
        {
            var cmd = new SqliteCommand("UPDATE Usuario SET NOMBRE = @nombre,  APELLIDO =  @apellido ,AREA = @area,PUESTO = @puesto ,tipo = @tip   WHERE ID = "+ id );
               
              
            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE);
            cmd.Parameters.AddWithValue("@apellido", co.APELLIDO);
            cmd.Parameters.AddWithValue("@area", co.AREA);
            cmd.Parameters.AddWithValue("@puesto", co.PUESTO);
            cmd.Parameters.AddWithValue("@tip", co.TIPO);

            executeCMD(cmd);
            return true;
        }
         public bool ActualizarServicio(Servicio co,int id)
        {
            var cmd = new SqliteCommand("UPDATE SERVICIO SET NOMBRE = @nombre,  NOMBRE_TECNICO =  @apellido ,AREA = @area,AULA = @puesto ,EQUIPO  = @tip ,FECHA  = @fech ,ESTADO = @est ,DESCRIPCION = @des WHERE ID = "+ id );
    
            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE);
            cmd.Parameters.AddWithValue("@apellido", co.NOMBRE_TECNICO);
            cmd.Parameters.AddWithValue("@area", co.AREA);
            cmd.Parameters.AddWithValue("@puesto", co.AULA);
            cmd.Parameters.AddWithValue("@tip", co.EQUIPO);
            cmd.Parameters.AddWithValue("@fech", co.FECHA );
           
              cmd.Parameters.AddWithValue("@est", co.ESTADO);
        cmd.Parameters.AddWithValue("@des", co.DESCRIPCION);        


 executeCMD(cmd);
            return true;
        }

         public bool ActualizarAula(Aula co, int id)
        {
             
            var cmd = new SqliteCommand("UPDATE Aula SET  NOMBRE = @nombre, " +
                "AREA =  @area ,DESCRIPCION = @des   WHERE ID = "+ id);
               
            
            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE);
            cmd.Parameters.AddWithValue("@des", co.DESCRIPCION);
            cmd.Parameters.AddWithValue("@area", co.AREA);
       
            executeCMD(cmd);
            return true;
        }
   public bool ActualizarEquipo_hd(Equipo co,int id)
        {
           

            var cmd = new SqliteCommand("UPDATE Equipo SET NOMBRE = @nombre,  Aula =  @aula ,Area = @area ,Fecha_adquisicion = @fech ,garantia = @gar ,ficha_tecnica = @ficha ,num_proveedor = @num WHERE ID = "+ id);
                
        
            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", co.AULA); 
            cmd.Parameters.AddWithValue("@area", co.AREA);
            cmd.Parameters.AddWithValue("@fech", co.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@gar", co.garantia); 
            cmd.Parameters.AddWithValue("@ficha", co.ficha_tecnica_hd); 
            cmd.Parameters.AddWithValue("@num", co.num_provee); 
  
         
       
            executeCMD(cmd);
            return true;
        }
         public bool ActualizarEquipo_hw(Equipo co ,int id)
        {
           
            
            var cmd = new SqliteCommand("UPDATE Equipo SET " + " NOMBRE = @nombre, " +
                "Aula =  @aula ,Area = @area ,Fecha_adquisicion = @fech ,garantia = @gar ,ficha_tecnica = @ficha ,num_proveedor = @num ,licencia = @lic WHERE ID = "+ id);
         
            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", co.AULA); 
            cmd.Parameters.AddWithValue("@area", co.AREA);
            cmd.Parameters.AddWithValue("@fech", co.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@gar", co.garantia); 
            cmd.Parameters.AddWithValue("@ficha", co.ficha_tecnica_hd); 
            cmd.Parameters.AddWithValue("@num", co.num_provee); 
           cmd.Parameters.AddWithValue("@lic", co.licencia_hw); 

  
         
       
            executeCMD(cmd);
            return true;
        }
          public bool ActualizarEquipo_red(Equipo co , int id)
        {
           
            
            var cmd = new SqliteCommand("UPDATE Equipo SET " + " NOMBRE = @nombre, " +
                "Aula =  @aula ,Area = @area ,Fecha_adquisicion = @fech ,garantia = @gar ,ficha_tecnica = @ficha ,num_proveedor = @num ,conectividad = @con WHERE ID = "+ id);

            cmd.Parameters.AddWithValue("@nombre", co.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", co.AULA); 
            cmd.Parameters.AddWithValue("@area", co.AREA);
            cmd.Parameters.AddWithValue("@fech", co.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@gar", co.garantia); 
            cmd.Parameters.AddWithValue("@ficha", co.ficha_tecnica_hd); 
            cmd.Parameters.AddWithValue("@num", co.num_provee); 
            cmd.Parameters.AddWithValue("@con", co.conectividad_red); 

  
         
       
            executeCMD(cmd);
            return true;
        }
        public bool BorrarTarea(int id)
        {
            var cmd = new SqliteCommand("DELETE FROM ContactoTable WHERE  ID = @id");
            cmd.Parameters.AddWithValue("@id", id);
            executeCMD(cmd);
            return true;
        }
        public bool BorrarServicio(int id)
        {
            var cmd = new SqliteCommand("DELETE FROM SERVICIO WHERE  ID = @id");
            cmd.Parameters.AddWithValue("@id", id);
            executeCMD(cmd);
            return true;
        }
        public bool BorrarUsuario(int id)
        {
            var cmd = new SqliteCommand("DELETE FROM Usuario WHERE  ID = "+id) ;
            cmd.Parameters.AddWithValue("@id", id);
            executeCMD(cmd);
            return true;
        }
         public bool BorrarAula(int id)
        {
            var cmd = new SqliteCommand("DELETE FROM Aula WHERE  ID = "+id);
            cmd.Parameters.AddWithValue("@id", id);
            executeCMD(cmd);
            return true;
        }
            public bool BorrarEquipo(int id)
        {
            var cmd = new SqliteCommand("DELETE FROM Equipo WHERE  ID = "+id);
            cmd.Parameters.AddWithValue("@id", id);
            executeCMD(cmd);
            return true;
        }
        public bool BorrarReferenciaA(int id, int id2)
        {
            var cmd = new SqliteCommand("DELETE FROM Referencia WHERE  id_ContactoA = @id  AND id_ContactoB =  @id2");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@id2", id2);
            executeCMD(cmd);
            return true;
        }
        public bool BorrarReferenciaB(int id,int id2)
        {
            var cmd = new SqliteCommand("DELETE FROM Referencia WHERE  id_ContactoB = @id  AND id_ContactoA = @id2");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@id2", id2);
            executeCMD(cmd);
            return true;
        }
        public int executeCMD(SqliteCommand cmd)
        {

            using (var con = new SqliteConnection(connection))
            {
                cmd.Connection = con;
                cmd.Connection.Open();
                
                var inserted = cmd.ExecuteNonQuery();

                return inserted;

            }
        }



       
        public bool CrearContacto(Contacto model)
        {
            var cmd = new SqliteCommand("INSERT INTO Usuario ( ID ,NOMBRE,APELLIDO,AREA,PUESTO ,tipo) VALUES (@_id, @nombre, @apellido, @area, @correo, @puesto, @edad, @date,@tipo)");
            cmd.Parameters.AddWithValue("@_id", model.id);
            cmd.Parameters.AddWithValue("@nombre", model.nombre);
            cmd.Parameters.AddWithValue("@apellido", model.apellido);
            cmd.Parameters.AddWithValue("@direccion", model.direccion);
            cmd.Parameters.AddWithValue("@correo", model.correo);
            cmd.Parameters.AddWithValue("@telefono", model.telefono);
            cmd.Parameters.AddWithValue("@edad", model.edad);
            cmd.Parameters.AddWithValue("@date", model.date);
            cmd.Parameters.AddWithValue("@tipo", model.tipocontacto);


            executeCMD(cmd);
            return true;
        }

         public bool CrearUsuario(Usuario model)
        {
             
            var cmd = new SqliteCommand("INSERT INTO Usuario ( ID ,NOMBRE,APELLIDO,AREA,PUESTO ,tipo) VALUES (@_id, @nombre, @apellido, @area, @puesto, @tipo)");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE); 
            cmd.Parameters.AddWithValue("@apellido", model.APELLIDO);
            cmd.Parameters.AddWithValue("@area", model.AREA);
            cmd.Parameters.AddWithValue("@puesto", model.PUESTO);
            cmd.Parameters.AddWithValue("@tipo", model.TIPO);


            executeCMD(cmd);
            return true;
        }
          public bool CrearServicio(Servicio model)
        {
             
            var cmd = new SqliteCommand("INSERT INTO SERVICIO  ( ID ,NOMBRE,NOMBRE_TECNICO,AREA,AULA,EQUIPO,FECHA,ESTADO,DESCRIPCION,FECHA_TERMINACION,CONFIGURACION,NOMBRE_ID,NOMBRE_TECNICO_ID,AULA_ID,EQUIPO_ID) VALUES (@_id, @nombre,@apellido,@area, @puesto ,@tipo ,@fech ,@est  ,@des ,@fech2 ,@conf, @nom2,  @nomt2 , @au2 , @equip2 )");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE);    
            cmd.Parameters.AddWithValue("@apellido", model.NOMBRE_TECNICO);       
            cmd.Parameters.AddWithValue("@area", model.AREA);
            cmd.Parameters.AddWithValue("@puesto", model.AULA);       ;
            cmd.Parameters.AddWithValue("@tipo", model.EQUIPO);        
            cmd.Parameters.AddWithValue("@fech", model.FECHA);
            cmd.Parameters.AddWithValue("@est", model.ESTADO);
            cmd.Parameters.AddWithValue("@des", model.DESCRIPCION);
            cmd.Parameters.AddWithValue("@fech2", model.FECHA_TERMINACION);
            cmd.Parameters.AddWithValue("@conf", model.CONFIGURACION);
            cmd.Parameters.AddWithValue("@nom2", model.NOMBRE_ID); 
            cmd.Parameters.AddWithValue("@nomt2", model.NOMBRE_TECNICO_ID);
            cmd.Parameters.AddWithValue("@au2", model.AULA_ID);
            cmd.Parameters.AddWithValue("@equip2", model.EQUIPO_ID);
            executeCMD(cmd);
            return true;
        }
         public bool CrearAula(Aula model)
        {
           
            
            var cmd = new SqliteCommand("INSERT INTO Aula ( ID ,NOMBRE, AREA , DESCRIPCION ) VALUES (@_id, @nombre, @area, @des)");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE); 
            cmd.Parameters.AddWithValue("@area", model.AREA); 
            cmd.Parameters.AddWithValue("@des", model.DESCRIPCION);
          
     


            executeCMD(cmd);
            return true;
        }

public bool CrearEquipoHD(Equipo model)
        {
           
            
        var cmd = new SqliteCommand("INSERT INTO Equipo ( ID ,NOMBRE ,Aula ,Area ,Fecha_adquisicion ,garantia ,ficha_tecnica ,num_proveedor , conectividad ,licencia ,tipo ) VALUES (@_id, @nombre, @aula, @area, @Fecha_adquisicion, @garantia, @ficha_tecnica, @num_proveedor, @con ,@lic ,@tip)");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", model.AULA); 
            cmd.Parameters.AddWithValue("@area", model.AREA);
            cmd.Parameters.AddWithValue("@Fecha_adquisicion", model.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@garantia", model.garantia); 
            cmd.Parameters.AddWithValue("@ficha_tecnica", model.ficha_tecnica_hd); 
            cmd.Parameters.AddWithValue("@num_proveedor", model.num_provee);
            cmd.Parameters.AddWithValue("@con", model.conectividad_red); 
            cmd.Parameters.AddWithValue("@lic", model.licencia_hw);
            cmd.Parameters.AddWithValue("@tip", model.TIPO);
  
            
         
 
       
            executeCMD(cmd);
            return true;
        }

public bool CrearEquipoHW(Equipo model)
        {
           
         
                 var cmd = new SqliteCommand("INSERT INTO Equipo ( ID ,NOMBRE ,Aula ,Area ,Fecha_adquisicion ,garantia ,ficha_tecnica ,num_proveedor , conectividad ,licencia ,tipo ) VALUES (@_id, @nombre, @aula, @area, @Fecha_adquisicion, @garantia, @ficha_tecnica, @num_proveedor, @con , @lic ,@tip)");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", model.AULA); 
            cmd.Parameters.AddWithValue("@area", model.AREA);
            cmd.Parameters.AddWithValue("@Fecha_adquisicion", model.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@garantia", model.garantia); 
            cmd.Parameters.AddWithValue("@ficha_tecnica", model.ficha_tecnica_hd); 
            cmd.Parameters.AddWithValue("@num_proveedor", model.num_provee); 
            cmd.Parameters.AddWithValue("@con", model.num_provee); 
            cmd.Parameters.AddWithValue("@lic", model.licencia_hw);
            cmd.Parameters.AddWithValue("@tip", model.TIPO);
              executeCMD(cmd);
            return true;

        }
public bool CrearEquipoRed(Equipo  model)
        {
           
             var cmd = new SqliteCommand("INSERT INTO Equipo ( ID ,NOMBRE ,Aula ,Area ,Fecha_adquisicion ,garantia ,ficha_tecnica ,num_proveedor ,conectividad ,licencia ,tipo ) VALUES (@_id, @nombre, @aula, @area, @Fecha_adquisicion, @garantia, @ficha_tecnica, @num_proveedor, @con , @lic , @tip )");
            cmd.Parameters.AddWithValue("@_id", model.ID);
            cmd.Parameters.AddWithValue("@nombre", model.NOMBRE); 
            cmd.Parameters.AddWithValue("@aula", model.AULA); 
            cmd.Parameters.AddWithValue("@area", model.AREA);
            cmd.Parameters.AddWithValue("@Fecha_adquisicion", model.Fecha_adquisicion_hw);
            cmd.Parameters.AddWithValue("@garantia", model.garantia);
            cmd.Parameters.AddWithValue("@ficha_tecnica", model.ficha_tecnica_hd);
            cmd.Parameters.AddWithValue("@num_proveedor", model.num_provee);
            cmd.Parameters.AddWithValue("@con", model.conectividad_red); 
            cmd.Parameters.AddWithValue("@lic", model.licencia_hw);
            cmd.Parameters.AddWithValue("@tip", model.TIPO);

            
              executeCMD(cmd);
            return true;
        }


         public bool CrearReferencia(Referencia model)
         {
             var cmd = new SqliteCommand("INSERT INTO Referencia (id_ContactoA,id_ContactoB,nombre_ContactoA,nombre_ContactoB) VALUES (@id_ContactoA,@id_ContactoB,@nombre_ContactoA,@nombre_ContactoB)");
            cmd.Parameters.AddWithValue("@ID", model.id);
            cmd.Parameters.AddWithValue("@id_ContactoA", model.id_ContactoA);
             cmd.Parameters.AddWithValue("@id_ContactoB", model.id_ContactoB);
             cmd.Parameters.AddWithValue("@nombre_ContactoA", model.nombre_ContactoA);
             cmd.Parameters.AddWithValue("@nombre_ContactoB", model.nombre_ContactoB);

             executeCMD(cmd);
             return true;
         }
        public List<Referencia> LeerReferencias(int id)
        {
            var cmd = new SqliteCommand("SELECT id_ContactoA,id_ContactoB ,nombre_ContactoA ,nombre_ContactoB FROM Referencia WHERE id_ContactoA  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            var Referencia = new List<Referencia>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Referencias = ParseReferencia(reader);
                        Referencia.Add(Referencias);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return Referencia;

        }

        private const string SELECTCONTACTO = "SELECT  ID ,NOMBRE,APELLIDO,DIRECCION,CORREO,TELEFONO,EDAD,DATE,TIPOCONTACTO  FROM  ContactoTable";
private const string SELECTUSUARIO = "SELECT  ID ,NOMBRE,APELLIDO,tipo,PUESTO,AREA FROM Usuario";

private const string SELECTAULAS = "SELECT  ID ,NOMBRE,AREA,DESCRIPCION FROM Aula";

private const string SELECTEQUIPO = "SELECT  ID ,NOMBRE,Aula,Area,Fecha_adquisicion,garantia,ficha_tecnica,num_proveedor,conectividad,licencia,tipo  FROM Equipo";
private const string SELECTSERVICIO = "SELECT  ID ,NOMBRE,NOMBRE_TECNICO,AREA,AULA,EQUIPO,FECHA,ESTADO,DESCRIPCION,FECHA_TERMINACION,CONFIGURACION ,NOMBRE_ID,NOMBRE_TECNICO_ID,AULA_ID,EQUIPO_ID FROM SERVICIO";
 
        public List<Contacto> LeerContactos()
        {

            var cmd = new SqliteCommand(SELECTCONTACTO);
            var contactos = new List<Contacto>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Contactos = ParseContacto(reader);
                        contactos.Add(Contactos);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return contactos;
        }


/*


 */
  public List<Servicio> LeerServicios()
        {

            var cmd = new SqliteCommand(SELECTSERVICIO);
            var servicio = new List<Servicio>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var servicios= ParseServicio(reader);
                        servicio.Add(servicios);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return servicio ;
        }
         public List<Usuario> LeerUsuarios()
        {

            var cmd = new SqliteCommand(SELECTUSUARIO);
            var usuarios = new List<Usuario>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Usuarios = ParseUsuarios(reader);
                        usuarios.Add(Usuarios);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return usuarios ;
        }


         public List<Equipo> LeerEquipo()
        {

            var cmd = new SqliteCommand(SELECTEQUIPO);
            var equipo = new List<Equipo>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Equipo = ParseEquipo(reader);
                        equipo.Add(Equipo);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return equipo ;
        }
         public List<Aula> LeerAula()
        {

            var cmd = new SqliteCommand(SELECTAULAS);
            var aula = new List<Aula>();
            using (var con = new SqliteConnection(connection))
            {
                /* try
                 {
                 */
                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Aula = ParseAulas(reader);
                        aula.Add(Aula);

                    }
                }
                /*
                   }
                   catch (Exception)
                   {


                   }
              */
            }
            return aula ;
        }
        public Contacto BuscarNombrePorID(string nombre)
        {

            var cmd = new SqliteCommand("SELECT  ID,NOMBRE,APELLIDO,DIRECCION,CORREO,TELEFONO,EDAD,DATE,TIPOCONTACTO FROM ContactoTable WHERE NOMBRE  = @nombre");
            cmd.Parameters.AddWithValue("@nombre", nombre);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var contacto = ParseContacto(reader);

                        return contacto;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }

        public Usuario LeerUsuariosPorId(int id)
        {

            var cmd = new SqliteCommand(SELECTUSUARIO+ " WHERE ID  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var usuario = ParseUsuarios(reader);

                        return usuario;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }
         public Aula LeerAulasPorId(int id)
        {

            var cmd = new SqliteCommand(SELECTAULAS+ " WHERE ID  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var aula = ParseAulas(reader);

                        return aula;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }
          public Equipo LeerEquipoPorId(int id)
        {

            var cmd = new SqliteCommand(SELECTEQUIPO+ " WHERE ID  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var equipo = ParseEquipo(reader);

                        return equipo;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }
        public Servicio LeerServiciosPorId(int id)
        {

            var cmd = new SqliteCommand(SELECTSERVICIO+ " WHERE ID  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var equipo = ParseServicio(reader);

                        return equipo;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }
        public Referencia LeerReferenciasPorId(int id)
        {

            var cmd = new SqliteCommand("SELECT  id_ContactoA, id_ContactoB, nombre_ContactoA, nombre_ContactoB FROM  Referencia  WHERE  id_ContactoA = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var contacto = ParseReferencia(reader);

                        return contacto;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }
        public Contacto LeerNombrePorId(int id)
        {
            
            var cmd = new SqliteCommand("SELECT NOMBRE FROM CONTACTOTABLE WHERE ID  = @id");
            cmd.Parameters.AddWithValue("@id", id);
            using (var con = new SqliteConnection(connection))
            {

                cmd.Connection = con;
                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {



                    if (reader.Read())
                    {

                        var contacto = ParseContacto(reader);

                        return contacto;

                    }
                    else
                    {
                        return null;
                    }
                }
            }



        }



        private Contacto ParseContacto(SqliteDataReader reader)
        {
            var contacto = new Contacto();
            var i = 0;
            unchecked
            {
                contacto.id = (int)reader.GetInt64(i++);
                contacto.nombre = reader.GetString(i++);
                contacto.apellido = reader.GetString(i++);
                contacto.direccion = reader.GetString(i++);
                contacto.correo = reader.GetString(i++);
                contacto.telefono = (int)reader.GetInt64(i++);
                contacto.edad = (int)reader.GetInt64(i++);
                contacto.date = reader.GetDateTime(i++);
               contacto.tipocontacto = reader.GetString(i++);



                return contacto;

            }










        }
        private Usuario ParseUsuarios(SqliteDataReader reader)
        {
            var Usuario = new Usuario();
            var i = 0;
            unchecked
            {

                 Usuario.ID = (int)reader.GetInt64(i++);               
                Usuario.NOMBRE = reader.GetString(i++);
                Usuario.APELLIDO = reader.GetString(i++);
                  Usuario.TIPO = reader.GetString(i++);
                 Usuario.PUESTO = reader.GetString(i++);

                Usuario.AREA = reader.GetString(i++);
                
           



                return Usuario;

            }
        }
 private Aula ParseAulas(SqliteDataReader reader)
        {
            var Aula = new Aula();
            var i = 0;
            unchecked
            {
                Aula.ID = (int)reader.GetInt64(i++);
                Aula.NOMBRE = reader.GetString(i++);
                Aula.AREA = reader.GetString(i++);
                Aula.DESCRIPCION = reader.GetString(i++);

             

            



                return Aula;

            }
        }

         private Equipo ParseEquipo(SqliteDataReader reader)
        {
            var Equipo = new Equipo();
            var i = 0;
            unchecked
            {
            Equipo.ID = (int)reader.GetInt64(i++);
            Equipo.NOMBRE = reader.GetString(i++);
            Equipo.AULA = reader.GetString(i++);
            Equipo.AREA = reader.GetString(i++);
            Equipo.Fecha_adquisicion_hw =  reader.GetString(i++);
            Equipo.garantia =  reader.GetString(i++);
            Equipo.ficha_tecnica_hd =  reader.GetString(i++);
            Equipo.num_provee = (int)reader.GetInt64(i++);    
            Equipo.conectividad_red = reader.GetString(i++);
            Equipo.licencia_hw  =  reader.GetString(i++);
            Equipo.TIPO =   reader.GetString(i++);

            



                return Equipo;

            }
        }
             private Servicio ParseServicio(SqliteDataReader reader)
        {
            var Equipo = new  Servicio();
            var i = 0;
            unchecked
            {
             Equipo.ID = (int)reader.GetInt64(i++);   
            Equipo.NOMBRE = reader.GetString(i++);             
            Equipo.NOMBRE_TECNICO = reader.GetString(i++);       
            Equipo.AREA = reader.GetString(i++);
            Equipo.AULA =  reader.GetString(i++);              
            Equipo.EQUIPO =  reader.GetString(i++);      
            Equipo.FECHA =  reader.GetString(i++);
            Equipo.ESTADO= reader.GetString(i++);    
            Equipo.DESCRIPCION =  reader.GetString(i++);
            Equipo.FECHA_TERMINACION = reader.GetString(i++);
            Equipo.CONFIGURACION =  reader.GetString(i++);
            Equipo.NOMBRE_ID = (int)reader.GetInt64(i++);     
            Equipo.NOMBRE_TECNICO_ID = (int)reader.GetInt64(i++); 
            Equipo.AULA_ID = (int)reader.GetInt64(i++);  
             Equipo.EQUIPO_ID =   (int)reader.GetInt64(i++); 
                return Equipo;

            }
        }

        private Referencia ParseReferencia(SqliteDataReader reader)
        {
            var contacto = new Referencia();
            var i = 0;
            unchecked
            {
        
                contacto.id_ContactoA= (int)reader.GetInt64(i++);
                contacto.id_ContactoB = (int)reader.GetInt64(i++);
                contacto.nombre_ContactoA = reader.GetString(i++);
                contacto.nombre_ContactoB = reader.GetString(i++);
               



                return contacto;

            }










        }
    }

}