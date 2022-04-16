using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo{
    
    internal class Program{
        
        static void Main(string[] args){

            Console.WriteLine(7 * 5); 

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
            Console.WriteLine($"Tienes una edad de {++edad} años");  
            Console.WriteLine($"Tienes una edad de {edad++} años");  
            Console.WriteLine($"Tienes una edad de {edad} años");  
            Console.WriteLine($"Tienes una edad de {edad} años");
         
        }
    }
}
