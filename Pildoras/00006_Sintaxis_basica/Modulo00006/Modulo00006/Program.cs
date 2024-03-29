﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ClaseBase { }
public class ClaseDerived : ClaseBase { }

namespace Modulo00006
{

    internal class Program{

        static void Main(string[] args)
        {

        
            Console.WriteLine("ok");
            // ///////////////////////////////////////////
            //  Declaración variables. 
            int edadPersona = 40;
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;
            int edadPersona5;
            // ///////////////////////////////////////////

            // ////////////////////////////////////////////////
            //  Podemos asignar valor  a varias variables al mismo tiempo
            //  Sirve para inicial-izar izar las variables todas juntas
            //  ademas debemos respetar le tipo de dato. 
            //  Esto no es común pero existe en el lenguaje
            edadPersona1 =
            edadPersona2 =
            edadPersona3 =
            edadPersona4 =
            edadPersona5 = edadPersona;
            // ////////////////////////////////////////////////
            // int edadPersona = 40;
            Console.WriteLine(edadPersona1);
            Console.WriteLine(edadPersona2);
            Console.WriteLine(edadPersona3);
            Console.WriteLine(edadPersona4);
            Console.WriteLine(edadPersona5);


            var variable = "Carlos";
            // Podemos dejar que el compilador asigne 
            // un tipo de dato en tiempo de ejecución. 
            Console.WriteLine(variable);

            // double x = 1234.7;
            // int a;
            // // Cast double to int.
            // a = (int)x;
            // System.Console.WriteLine(a);

            //  Declaración explicita 

            double numeroDouble = 2.36;
            int numeroInt;
            numeroInt =(int) numeroDouble;
            Console.WriteLine(numeroInt);


            //  Declaración implícita 

            int numeroIntImplicito = 10;

            long nuevoNumeroImplicito = numeroIntImplicito;

            Console.WriteLine(numeroIntImplicito);


            object instanciaDeClase1 = new ClaseBase();
            Console.WriteLine(instanciaDeClase1 is ClaseBase);  // imprime: True
            Console.WriteLine(instanciaDeClase1 is ClaseDerived);  // imprime: False

            object instanciaDeClase2 = new ClaseDerived();
            Console.WriteLine(instanciaDeClase2 is ClaseBase);  // imprime: True
            Console.WriteLine(instanciaDeClase2 is ClaseDerived); // imprime: True


            //  Conversión simplista  de variables 
            var valor0 = 5;
           // short tiposhort = valor0;     Error de conversión implícita
            int tipoint = valor0;
            long tipolong = valor0;
            float tipofloat = valor0;
            double tipodouble = valor0;
            decimal  tipodecimal = valor0;
           // nint tiponint = valor0;       Error de conversión implícita





        }
    }
}
