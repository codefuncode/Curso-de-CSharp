using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo{
    
    internal class Program{
        
        static void Main(string[] args){

            Console.WriteLine(7 * 5); 
            ////////////////////////////////////////////////////////////////////////////////////////////
            // Nota en la división si los valores ambos son enteros el resultado 
            // será un entero y si hay decimal el resultado será decimal
            Console.WriteLine("======================================"); 
            // ////////////////////////////////////////////////////////
            // Esto dará como resultado un valor de tipo int 
            Console.WriteLine(5/2);
            //  Imprime 
            // ////////////////////////////////////////////////////////

            Console.WriteLine("======================================"); 

            // ///////////////////////////////////////////////////////
            //  Dará como resultado un valor decimal
            Console.WriteLine(5.0/2.0);
            // ///////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("======================================"); 

            // ///////////////////////////////////////////////////////
            //  Dará como resultado un valor decimal
            Console.WriteLine(9 % 3);
            // Imprime 0
            Console.WriteLine("======================================"); 
            // ///////////////////////////////////////////////////////

            // ///////////////////////////////////////////////////////
            //  Dará como resultado un valor decimal
            Console.WriteLine(9 % 4);
            // Imprime 1
            Console.WriteLine("======================================");
            // ///////////////////////////////////////////////////////


            int edad = 40;
            // edad++;
            // -------------------------------------------------------
            // Operador ++ al principio adjudica valor y despliega 
            Console.WriteLine($"Tienes una edad de {++edad} años"); 
            // -------------------------------------------------------
            // Operador ++ a continuación despliega valor y después adjudica 
            Console.WriteLine($"Tienes una edad de {edad++} años");  
            // -----------------------------------------------------

            Console.WriteLine($"Tienes una edad de {edad} años");  
            Console.WriteLine($"Tienes una edad de {edad} años");

            var jh = (
                firstName: "Jupiter",
                 lastName: "Hammon",
                  born: 1711,
                   published: 1761
                );
            // //////////////////////////////////////////////////
            //  Note la posibilidad de continuar en una nueva linea 
            //  usando operador mas y signo de $ en la linea a continuación 
            Console.WriteLine(
                $"{jh.firstName} " +
                $"{jh.lastName} " +
                $"fue un poeta afroamericano nacido en " +
                $"{jh.born}."
                );
            // //////////////////////////////////////////////////
            Console.WriteLine(
                $"Se publicó por primera vez en {jh.published}  a la edad de {jh.published - jh.born} años."
                );
            Console.WriteLine(
                $"Tendría más de {Math.Round((2018d - jh.born) / 100d) * 100d} años hoy."
                );

            // Producción:
            // Jupiter Hammon fue un poeta afroamericano nacido en 1711.
            // Se publicó por primera vez en 1761 a la edad de 50 años.
            // Tendría más de 300 años hoy.
         
        }
    }
}
