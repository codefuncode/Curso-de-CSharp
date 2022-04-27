using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Modulo00007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // -------------------------------------------
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            // -------------------------------------------
            // Console.Write("Press any key to continue");
            //Console.ReadKey();
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


            // ////////////////////////////////////////////////////////


            // // Define an array of string values.
            // string[] values = 
            // { 
            //   " 987.654E-2",
            //   " 987,654E-2",
            //   "(98765,43210)",
            //   "9,876,543.210",
            //   "9.876.543,210",
            //   "98_76_54_32,19" 
            //  };
            // // Create a custom culture based on the invariant culture.

            // CultureInfo ci = new CultureInfo("");
            // ci.NumberFormat.NumberGroupSizes = new int[] { 2 };
            // ci.NumberFormat.NumberGroupSeparator = "_";

            // // Define an array of format providers.
            // CultureInfo[] providers = { new CultureInfo("en-US"),
            // new CultureInfo("nl-NL"), ci };

            // // Define an array of styles.
            // NumberStyles[] styles = { NumberStyles.Currency, NumberStyles.Float };

            // // ----------------------------------------------------------------------------------
            // // Iterate the array of format providers.
            // foreach (CultureInfo provider in providers) {

            //     Console.WriteLine(
            //         "Parsing using the {0} culture:",
            //         provider.Name == String.Empty ? "Invariant" : provider.Name
            //     );

            //     // Parse each element in the array of string values.
            //     foreach (string value in values) {

            //         foreach (NumberStyles style in styles) {

            //             try {
            //                 float number = Single.Parse(value, style, provider);
            //                 Console.WriteLine("   {0} ({1}) -> {2}",
            //                 value, style, number);
            //             }
            //             catch (FormatException) {

            //                 Console.WriteLine("   '{0}' is invalid using {1}.", value, style);
            //             }
            //             catch (OverflowException) {

            //                 Console.WriteLine("   '{0}' is out of the range of a Single.", value);
            //             }
            //         }
            //     }

            //     Console.WriteLine();
            // }
            // ----------------------------------------------------------------------------------
        }
    }
}
