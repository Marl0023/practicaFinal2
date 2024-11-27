using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_2;

namespace practica_2
{
    public class Mascota
    {
        public int mascotaCount = 0;
        public static Mascota[] mascotas = new Mascota[10];
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }
        public override string ToString() => $"Nombre: {Nombre}, Edad: {Edad}, Especie: {Especie}";
        public static Mascota CrearMascota()
        {
            Console.Write("Nombre de la mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad de la mascota: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Especie de la mascota: ");
            string especie = Console.ReadLine();

            return new Mascota { Nombre = nombre, Edad = edad, Especie = especie };
        }
        public void CrearMasc()
        {
            if (mascotaCount < mascotas.Length)
            {
                mascotas[mascotaCount++] = Mascota.CrearMascota();
                Console.WriteLine("Mascota creada con éxito.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más mascotas.");
            }
            Console.ReadKey();
        }
        public void EliminarMasc()
        {
            ListarMasc();
            Console.Write("Seleccione el índice de la mascota a eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < mascotaCount)
            {
                for (int i = index; i < mascotaCount - 1; i++)
                {
                    mascotas[i] = mascotas[i + 1];
                }
                mascotas[--mascotaCount] = null;
                Console.WriteLine("Mascota eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            Console.ReadKey();
        }
        public void ListarMasc()
        {
            Console.WriteLine("=== Lista de Mascotas ===");
            for (int i = 0; i < mascotaCount; i++)
            {
                Console.WriteLine($"{i}. {mascotas[i]}");
            }
            Console.ReadKey();
        }
    }
}
