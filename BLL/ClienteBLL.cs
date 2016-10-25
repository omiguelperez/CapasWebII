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
        public int Insertar(ClienteDTO cliente)
        {
            using(Contexto db = new Contexto())
            {
                Cliente c = new Cliente();
                c.ClienteId = cliente.ClienteId;
                c.Direccion = cliente.Direccion;
                c.Nombre = cliente.Nombre;
                c.Telefono = cliente.Telefono;
                db.Clientes.Add(c);
                return db.SaveChanges();
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
