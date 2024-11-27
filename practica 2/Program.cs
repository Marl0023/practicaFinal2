using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using practica_2;

namespace practica_2
{
    public class Program
    {
        static Boleta[] boletas = new Boleta[10];
        public static Mascota masc = new Mascota();
        public static Boleta bole= new Boleta();
        static void Main(string[] args)
        {
            Servicio serv = new Servicio();
            
            int opc = 0;
            do
            {
                Console.WriteLine("Menu de veterianria");
                Console.WriteLine("\n\t1-Crear Servicio\n\t2-Eliminar Servicio\n\t3-Listar Servicios");
                Console.WriteLine("\n\t4-Crear Mascota\n\t5-Eliminar Mascota\n\t6-Listar Mascotas");
                Console.WriteLine("\n\t7-Crear Boleta\n\t8-Listar Boletas\n\t9-Salir");
                Console.Write("Ingrese su opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        serv.CrearServ();
                        break;
                    case 2: 
                        serv.EliminarServ();
                        break;
                    case 3: 
                        serv.ListarServ();
                        break;
                    case 4: 
                        masc.CrearMasc();
                        break;
                    case 5: 
                        masc.EliminarMasc();
                        break;
                    case 6: 
                        masc.ListarMasc(); 
                        break;
                    case 7: 
                        bole.CrearBoleta(); 
                        break;
                    case 8: 
                        bole.ListarBoletas(); 
                        break;
                    case 9:
                        Console.WriteLine("Cerrando Programa...");
                        break;
                    default:
                        Console.WriteLine("Error vuelva intentarlo");
                        break;
                }
            } while (opc != 9);
            Console.ReadKey();
        }
        
        
        
        


    }
}
