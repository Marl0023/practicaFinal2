using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_2;

namespace practica_2
{
    public class Servicio
    {
        public Servicio[] servicios = new Servicio[10];
        public int servicioCount = 0;
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public override string ToString() => $"Descripción: {Descripcion}, Precio: {Precio:C}";
        public static Servicio CrearServicio()
        {
            Console.Write("Descripción del servicio: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio del servicio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            return new Servicio { Descripcion = descripcion, Precio = precio };
        }
        public  void CrearServ()
        {
            if (servicioCount < servicios.Length)
            {
                servicios[servicioCount++] = Servicio.CrearServicio();
                Console.WriteLine("Servicio creado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más servicios.");
            }
            Console.ReadKey();
        }
        public void EliminarServ()
        {
            ListarServ();
            Console.Write("Seleccione el índice del servicio a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < servicioCount)
            {
                for (int i = index; i < servicioCount - 1; i++)
                {
                    servicios[i] = servicios[i + 1];
                }
                servicios[--servicioCount] = null;
                Console.WriteLine("Servicio eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            Console.ReadKey();
        }
        public void ListarServ()
        {
            Console.WriteLine("=== Lista de Servicios ===");
            for (int i = 0; i < servicioCount; i++)
            {
                Console.WriteLine($"{i}. {servicios[i]}");
            }
            Console.ReadKey();
        }
    }
}
