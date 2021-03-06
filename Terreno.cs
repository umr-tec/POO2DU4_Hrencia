using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2DU4_Ejemplo1
{  
    public class Terreno : Inmueble
    {
        private bool serviciosBasicos;
        private string condicionesSuelo;
        private bool cimientos;


        public Terreno(int metrosCuadrados, string calle, double precioVenta, string escrituras,
            bool serviciosBasicos, string condicionesSuelo, bool cimientos) 
        :base(metrosCuadrados,calle,precioVenta,escrituras)
        {
            this.serviciosBasicos = serviciosBasicos;
            this.condicionesSuelo = condicionesSuelo;
            this.cimientos = cimientos;
        }

        public Terreno() {
            //evitar ecepciones no contriooladas
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cuales son las condiciones del suielo");
                condicionesSuelo = Console.ReadLine();
                Console.WriteLine("El terreno cuenta con servicios basicos ");
                serviciosBasicos = Convert.ToBoolean(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString());
            }


            

        }


        public override void DetallesDeInmueble()
        {
            base.DetallesDeInmueble();
            Console.WriteLine("Detalles especificos del terreno");
            Console.WriteLine("Serivicios basicos disponibles (agua - luz) {0}", serviciosBasicos);
            Console.WriteLine("Cuenta con cimientos {0}", cimientos);
        }
    }
}