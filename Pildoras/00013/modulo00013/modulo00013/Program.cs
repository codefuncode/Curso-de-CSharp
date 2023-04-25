using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo00013 {

    internal class Program{

        static void Main(string[] args){
            
            MiMetodo("Liam");
            MiMetodo("Jenny");
            MiMetodo("Anja");
            MiMetodo("Sweden");
            MiMetodo("India");
            MiMetodo();
            MiMetodo("USA");

            int miNumero1 = MetodoInt(8, 5);
            double miNUmnero2 = MetodoDouble(4.3, 6.26);
            Console.WriteLine("Int: " + miNumero1);
            Console.WriteLine("Double: " + miNUmnero2);
            // ------------------------------------------
            int miNumero3 = MetodoSobreCarga(8, 5);
            double miNumero4 = MetodoSobreCarga(4.3, 6.26);
            Console.WriteLine("Int: " + miNumero3);
            Console.WriteLine("Double: " + miNumero4);
        }

        static void MiMetodo(string country = "Norway") {
            Console.WriteLine(country);
        }


        //  Se usa sobre carga aquí lo cual consta de los mismos 
        //  métodos con diferentes parámetros o diferentes tipo 
        //  de dato en los parámetros 
        static int MetodoInt(int x, int y) {
            return x + y;
        }

        static double MetodoDouble(double x, double y) {
            return x + y;
        }

        // --------------------------------------------------
        static int MetodoSobreCarga(int x, int y) {
        return x + y;
        }

        static double MetodoSobreCarga(double x, double y){
        return x + y;
        }

    }
}
