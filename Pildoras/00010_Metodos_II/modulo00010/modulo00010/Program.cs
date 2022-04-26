using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo00010 {

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
}
