using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DU4_Ejemplo1
{
    public class Inmueble
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingresa el nombre del propietario");
            escrituras = Console.ReadLine();
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
