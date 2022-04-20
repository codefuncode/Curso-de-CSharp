using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo00008{

    internal class Program{

        static void Main(string[] args){

            //  Las constantes deben declarar e iniciar en la misma linea 

            // const int VALOR = 20; 
            // const int VALOR2 = 21;

            //  No se permite cambiar el valor de las constantes 
            // VALOR = 21;

            // Console.WriteLine("El valor de la constante es {1}",VALOR,VALOR2);


            Console.WriteLine("Introduce el radio para calcular el área del circulo");
            const double PI = 3.1416;

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;

            Console.WriteLine($"El área del; circulo es {area}");


        }
    }
}
