using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DU4_Ejemplo1
{
    interface IInmuebles
    {
        //implemetar un metodo para calcular el cisnto de un terreno
        double CalcularCostoTerreno(double precioMetroCuadrado);
        void MostrarCliente_Vendedor(string clientge, string vendedor);
    }
}
