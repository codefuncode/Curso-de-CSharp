using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo00011 {
    internal class Program {
        static void Main(string[] args) {

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            int valor0 = PlusMethod(10, 10);
            Console.WriteLine(valor0); 
            
            double valor1 = PlusMethod(10, 10); 
            Console.WriteLine(valor1);
            
            // Al usar la sobrecarga debe pasarse como valor de  parámetro
            // un valor que represente el tipo de dato requerido.
            string valor2 = PlusMethod(10.0, 10);
            Console.WriteLine(valor2);

        }
        
        // -------------------------------------------------------------
        static int PlusMethod(int x, int y) {
            return x + y;
        }

        // -------------------------------------------------------------
        static double PlusMethod(double x, double y) {
            return x + y;
        }

        // -------------------------------------------------------------
        static string PlusMethod(double x, int y) {
            return $"El valor de la suma entre {x} y {y} es: {x+y}";
        }
        // -------------------------------------------------------------
        //  El confortamiento en cuanto a las operaciones aritméticas
        //  debe tomarse con cautela  pues una operación aritmética 
        //  entre int y un double siempre da como resultado un  double 
        static double sumar(double valor1, double valor2){
            return valor1 + valor2;
        }
        static double restar(double valor1, double valor2){
            return valor1 + valor2;
        }        
        static double multiplicar(double valor1, double valor2){
            return valor1 + valor2;
        }        
        static double dividir(double valor1, double valor2){
            return valor1 + valor2;
        }

    }
}
