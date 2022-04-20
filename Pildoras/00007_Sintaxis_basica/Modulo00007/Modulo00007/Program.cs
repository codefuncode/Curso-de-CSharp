using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo00007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int res;
            // string myStr = "200";
            // res = int.Parse(myStr);
            // Console.WriteLine("String is a numeric representation: "+res);
            Console.WriteLine("Introduice el primer numero");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduice el segundo numero");
            int valor2 = int.Parse(Console.ReadLine());
            int res = valor1 + valor2;
            Console.WriteLine($"La suma d elos numeros es: {res}");
        }
    }
}
