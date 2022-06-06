using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DU4_Ejemplo1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar un objeto
            int metros;
            //Console.WriteLine("Ingresa los metros del imueble");
            //metros = Convert.ToInt32(Console.ReadLine());          

            //Console.WriteLine("\n");

            //Terreno objetoTerreno1 = new Terreno(metros, "Bosque de los pinos", 1000000.98, "UMR",true,"Arenoso",false);
            //objetoTerreno1.DetallesDeInmueble();
            //Console.WriteLine("Costo total del terreno: $"+ objetoTerreno1.CalcularCostoTerreno(120));

            Console.WriteLine("\n");
            Terreno objetoTerreno2 = new Terreno();
            objetoTerreno2.DetallesDeInmueble();


            Console.ReadKey();
        }
    }
}
