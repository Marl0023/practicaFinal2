using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_2;

namespace practica_2
{
    public class Boleta
    {
        private int mascotaCount;
        public int Codigo { get; set; }
        
        public Mascota Mascota { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public decimal Total1 { get; set; }
        public Mascota[] mascotas= new Mascota[10];
        public int servicioCount;
        public Servicio[] servicios = new Servicio[10];
        public int boletaCount;
        public Boleta[] boletas = new Boleta[10];
        public static Mascota masc = new Mascota();
        public Servicio serv = new Servicio();
        public override string ToString() =>
            $"Código: {Codigo}, Mascota: {Mascota.Nombre}, Servicio 1: {Servicio1.Descripcion}, Servicio 2: {Servicio2.Descripcion}, Total: {Total1:C}";
        public void CalcularTotal()
        {
            Total1 = Servicio1.Precio + Servicio2.Precio;
        }
        public void CrearBoleta()
        {
            masc.ListarMasc();
            
            Console.Write("Seleccione el índice de la mascota: ");
            int mascotaIndex = int.Parse(Console.ReadLine());

            if (mascotaIndex >= 0 && mascotaIndex < mascotaCount)
            {
                Mascota mascotaSeleccionada = mascotas[mascotaIndex];

                masc.ListarMasc();
                Console.Write("Seleccione el índice del primer servicio: ");
                int servicio1Index = int.Parse(Console.ReadLine());
                Console.Write("Seleccione el índice del segundo servicio: ");
                int servicio2Index = int.Parse(Console.ReadLine());

                if (servicio1Index >= 0 && servicio1Index < servicioCount &&
                    servicio2Index >= 0 && servicio2Index < servicioCount)
                {
                    Servicio servicio1 = servicios[servicio1Index];
                    Servicio servicio2 = servicios[servicio2Index];

                    Boleta nuevaBoleta = new Boleta
                    {
                        Codigo = boletaCount + 1,
                        Mascota = mascotaSeleccionada,
                        Servicio1 = servicio1,
                        Servicio2 = servicio2
                    };
                    nuevaBoleta.CalcularTotal();

                    boletas[boletaCount++] = nuevaBoleta;
                    Console.WriteLine("Boleta creada con éxito.");
                }
                else
                {
                    Console.WriteLine("Índices de servicios inválidos.");
                }
            }
            else
            {
                Console.WriteLine("Índice de mascota inválido.");
            }
            Console.ReadKey();
        }
        public void ListarBoletas()
        {
            Console.WriteLine("=== Lista de Boletas ===");
            for (int i = 0; i < boletaCount; i++)
            {
                Console.WriteLine($"{i}. {boletas[i]}");
            }
            Console.ReadKey();
        }
    }
}
