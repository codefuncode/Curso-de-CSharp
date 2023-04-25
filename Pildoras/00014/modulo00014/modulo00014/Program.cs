using System;

namespace modulo00014
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int y = 20;
            int x ;
            Console.WriteLine($"Introduce un numero para saber si es mayor o menor que {y}");
            x = int.Parse(Console.ReadLine());
            bool respuesta = (x > y);
            if (x > y)
            {
                Console.WriteLine($"{x} es mayor que {y}");
            }
            else
            {
                Console.WriteLine($"{x} es menor que {y}");
            }

            if(respuesta) Console.WriteLine($"xxx {x} es mayor que {y}");
            else Console.WriteLine($"xxxx {x} es menor que {y}");



        }
    }
}
