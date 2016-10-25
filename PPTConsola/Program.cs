using Entities;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteDTO cliente1 = new ClienteDTO
            {
                Nombre = "Oscar",
                Direccion = "San Joaquin",
                Telefono = "3113931898"
            };

            ClienteBLL clienteBLL = new ClienteBLL();
            int nr = clienteBLL.Insertar(cliente1);

            Console.WriteLine("se realzo la operacion; Numero de registros afectados " + nr);
            Console.ReadKey();
            Console.WriteLine("Consulta de datos");
            
            foreach (var item in clienteBLL.GetRecords())
            {
                Console.WriteLine(item.Nombre + " " + item.Telefono);
            }
            Console.ReadKey();
        }
    }
}
