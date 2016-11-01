using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        Respuesta respuesta = new Respuesta();
        Contexto db = new Contexto();

        public Respuesta Insertar(ClienteDTO cliente)
        {
            using(db = new Contexto())
            {
                try
                {
                    // preparar el cliente para guardar
                    Cliente c = new Cliente();
                    c.ClienteId = cliente.ClienteId;
                    c.Direccion = cliente.Direccion;
                    c.Nombre = cliente.Nombre;
                    c.Telefono = cliente.Telefono;
                    db.Clientes.Add(c);
                    
                    // preparar la respuesta
                    respuesta.FilasAfectadas = db.SaveChanges();
                    respuesta.Mensaje = "Se realizó la operación satisfactoriamente";
                    respuesta.Error = false;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    respuesta.Mensaje = ex.Message;
                    respuesta.FilasAfectadas = 0;
                    respuesta.Error = true;
                }
                catch (Exception ex)
                {
                    respuesta.Mensaje = ex.Message;
                    respuesta.FilasAfectadas = 0;
                    respuesta.Error = true;
                }

                return respuesta;
            }
        }

        public List<ClienteDTO> GetRecords()
        {
            using(Contexto db = new Contexto())
            {
                return db.Clientes
                    .Select(t => 
                        new ClienteDTO 
                        {
                            ClienteId = t.ClienteId,
                            Nombre = t.Nombre,
                            Direccion = t.Direccion,
                            Telefono = t.Telefono
                        }
                    ).ToList();
            }
        }
    }
}
