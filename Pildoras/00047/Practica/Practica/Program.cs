using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Instancia Avion");

            Avion miavion = new Avion();
            miavion.ArrancaMotor("taca ta");
            miavion.Despegar();
            miavion.Conducir();
            miavion.PararMotor("Toco toco"); 
            Console.WriteLine("Instancia Avion");

            Cohe micohe = new Cohe();
            micohe.ArrancaMotor("Rum Rum");
            micohe.Acelarar();
            micohe.Frenar();
            micohe.PararMotor("Rumpp Rumpp");


        }
    }
}
