using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DU4_Ejemplo1
{
    public class Inmueble : IInmuebles
    {
        private int metrosCuadrados;
        private string calle;
        private string colonia;
        private string ciudad;
        private double precioVenta;
        private string cp;
        private double precioRenta;
        private string numeroLote;
        private string escrituras;
        private string propietario;


        //Miembros
        //Constructrores
        //Por lo menos un constructor vacio
        public Inmueble(){
            Console.ForegroundColor = ConsoleColor.Yellow;

            try
            {
                Console.WriteLine("Seleccionaste el constructor sin params");

                Console.WriteLine("Ingresa el nombre del propietario");
                escrituras = Console.ReadLine();

                Console.WriteLine("Ingresa los metros cuadrados del inmueble");
                metrosCuadrados = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingresa la direccion del inmueble");
                calle = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
                     
        }

        //Constructor sobrecargado
        public Inmueble(int metrosCuadrados, string calle, double precioVenta, string escrituras) {
            //para acceder a variables globales desde un miebro, hay que usar el apuntador
            //this
            this.metrosCuadrados = metrosCuadrados;
            this.calle = calle;
            this.precioVenta = precioVenta;
            this.escrituras = escrituras;
        }

        public double CalcularCostoTerreno(double precioMetroCuadrado)
        {
            return precioMetroCuadrado * metrosCuadrados;
        }

        public virtual void DetallesDeInmueble()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ventas online de inmuebles San Pedro Corporation");

            //Console.WriteLine("Escrituras a nombre de {0}", escrituras);
            string mensaje = string.Format("Escrituras a nombre de {0}. \n " +
                "Dirección {1}. \n " +
                "Metros de terreno {2} \n" +
                "Precio de venta ${3}",escrituras,calle,metrosCuadrados,precioVenta);

            Console.WriteLine(mensaje);
        }
    }
}
