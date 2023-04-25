using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo00012 {

    internal class Program {

        // Ámbito de las variables

        // A nivel de bloque: Sólo el código del bloque tendrá la 
        // posibilidad de trabajar con la variable (por ejemplo un bucle for next)

        // A nivel de función: Sólo el código de la función donde se 
        // declara la variable podrá modificar su contenido, se 
        // llama normalmente variable local.

        // A nivel de clase: Una variable declarada en el interior de 
        // una clase es accesible al código de esta clase sin restricción 
        // y eventualmente a partir de otras porciones de código en 
        // función del nivel de acceso de la variable.

        // Nivel de acceso de las variables

        // public: Los elementos declarados serán accesibles desde 
        // cualquier porción de código del proyecto y desde cualquier 
        // otro proyecto que haga referencia a aquel donde están declarados. 
        // No se pueden utilizar dentro en el interior de las funciones.

        // protected: Se puede utilizar en el interior de una clase. 
        // Permite restringir el acceso a la variable únicamente al código 
        // de la clase y todas las clases que hereden de ella.
        
        // internal: Serán accesibles desde el ensamblado en el cual 
        // están declarados y tampoco se pueden utilizar en el interior de una función.
        
        // protected internal: Es el nivel de acceso de protected e internal.
        
        // private: restringe el acceso a la variable al módulo, a 
        // la clase o a la estructura en la cual está declarada. No se puede 
        // utilizar en el interior de un procedimiento o función.

        //  Referencia 
        // https://csharp.com.es/ambito-de-las-variables/

        // -------------------------
        //  Variable global
        int     variable1 = 1;
        double  variable2 = 2;
        string  variable3 = "texto";
        // -------------------------
        static void Main(string[] args){

            metodo(5,5);
            metodo(5.5,5);
            metodo(5,5,5);

        }

        // -----------------------------------
        //  Ejemplos de definiciones y ámbito de variables

        //  Sobrecarga de métodos

        static void metodo(int param1, int param2){

            Console.WriteLine($"Primera sobrecarga");
        
        }
        static void metodo(double param1, int param2){

            Console.WriteLine($"Segunda sobrecarga");
        
        }
        static void metodo(int param1, int param2, int param3){

            Console.WriteLine($"Tercera sobrecarga");
        
        }
    }
}
