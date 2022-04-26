using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo00010 {
<<<<<<< HEAD

	 internal class Program {
			//  ---------------------------------------
			// Metodo declarado antes de metodo main
			static void mensajeEnPantalla0(){

			Console.WriteLine("Mensaje en pantalla 0");

			}
			//  ---------------------------------------
		  static void Main(string[] args) {
		  		mensajeEnPantalla0();
				Console.WriteLine("ok");
				mensajeEnPantalla1();

		  }

		 //  -------------------------------------------
      // Método declarado después del método main
      static void mensajeEnPantalla1(){

         Console.WriteLine("Mensaje en pantalla 1");

      }
      //  -------------------------------------------

	 }
=======
  internal class Program{
      // ////////////////////////////////////////// 
      //  Metodo  declarado antes de metodo main
      static void mensajeEnPantalla0(){

        Console.WriteLine("Mensaje en pantalla 0");

      }
      // ////////////////////////////////////////// 
      static void Main(string[] args){

        
        mensajeEnPantalla0();
        mensajeEnPantalla0();
        mensajeEnPantalla0();
        mensajeEnPantalla0();
        mensajeEnPantalla0();
        Console.WriteLine("Mensaje en el main");
        mensajeEnPantalla1();
        mensajeEnPantalla1();
        mensajeEnPantalla1();
        mensajeEnPantalla1();
        mensajeEnPantalla1();
        mensajeEnPantalla1();

        Marodo0("Liam");
        Marodo0("Jenny");
        Marodo0("Anja");
        Metodo1();
        Metodo1("ok");
        Metodo1("Hola");
        Metodo1();
        Metodo1("2");
        Metodo1();

        int resultadoSuma = Sumar(5,5);
        Console.WriteLine($"El resultado  de l asuma es {resultadoSuma}");


        
        MetodoClaveValor();
        MetodoClaveValor(clave0: "clave 0 llena");
        MetodoClaveValor( 
          clave0: "clave0",
          clave1: "clave1", 
          clave2: "clave2"
        );
        MetodoClaveValor(clave2: "clave2");



      }
      //  //////////////////////////////////////////////
      //  Método declarado después del método main
     static void mensajeEnPantalla1(){

        Console.WriteLine("Mensaje en pantalla 1");

      }
      //  //////////////////////////////////////////////


      // ////////////////////////////////////////
      //  Método que recibe paramentos
      static void Marodo0(string param) {

      Console.WriteLine($"El valor del parametro es : {param}");

      }
      // ////////////////////////////////////////


      //  ////////////////////////////////////////
      //  Método que recibe parámetro opcional con un valor por defecto
      static void 
      Metodo1(string param = "Valor Por defecto"){
     
      Console.WriteLine($"El valor del parametro es : {param}");

      }
      //  ////////////////////////////////////////


      // ///////////////////////////////////////
      //  REcibe paramentos y se usa return para retornar algún valor 
      static int Sumar(int x, int y) 
      {
        return x + y;
      }
      // ///////////////////////////////////////


      //  /////////////////////////////////////////////////////
      //  Métodos  con variables clave valor hace todos los valores 
      // opcionales y  no importa  le ordenen que los pasees 
      // después que sea clave valor.
      static void MetodoClaveValor(
        string clave0 = " Vacio",
        string clave1 = " Vacio",
        string clave2 = " Vacio"
        ) {

          Console.WriteLine($"================================");
          Console.WriteLine($"El valor de la clave0: {clave0}");
          Console.WriteLine($"El valor de la clave1: {clave1}");
          Console.WriteLine($"El valor de la clave2: {clave2}");

      }
      //  /////////////////////////////////////////////////////


  }
>>>>>>> e7e7a4b72881638a8afabf1f2ae4c7dab47bed1c
}
