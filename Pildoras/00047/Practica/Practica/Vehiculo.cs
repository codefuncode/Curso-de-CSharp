using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Vehiculo
    {


        public void ArrancaMotor(string sonidoMotor){       
            Console.WriteLine($"Motor arancado: {sonidoMotor}");
        }

         public void PararMotor(string sonidoAlParar){
            Console.WriteLine($"Motor parando: {sonidoAlParar}");
        }

        public virtual void Conducir(){
            Console.WriteLine("Condiciando");
        }
    }
}
