using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Cohe:Vehiculo
    {

        public void Acelarar(){
            Console.WriteLine("Acelarando");
        }

        public void Frenar(){
            Console.WriteLine("Frenando");
        }

        public override void Conducir(){
            // base.Conducir();
        }
    }
}
