using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
   internal class Program{
       static void Main(string[] args){
            Console.WriteLine("================================================================="); 
            Console.WriteLine("Presione enter para ver continuar");
            Console.ReadKey();
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hola";

            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            byte edad = 28;
            Console.WriteLine(edad);
            Console.WriteLine("=================================================================");
            Console.ReadKey();

            // ////////////////////////////////////////////////////////////////////////
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo byte:" + v1);
            sbyte v2=-100;
            Console.WriteLine("Valor almacenado en la variable de tipo sbyte:" + v2);
            // ////////////////////////////////////////////////////////////////////////
            short v3 = 30000;
            Console.WriteLine("Valor almacenado en la variable de tipo short:" + v3);
            ushort v4 = 60000;
            Console.WriteLine("Valor almacenado en la variable de tipo ushort:" + v4);
            // ////////////////////////////////////////////////////////////////////////
            int v5 = -2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo int:" + v5);
            uint v6 = 2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo uint:" + v6);
            // ////////////////////////////////////////////////////////////////////////
            long v7 = -1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo long:" + v7);
            ulong v8 = 1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ulong:" + v8);
            // ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("=================================================================");
            Console.ReadKey();

            // //////////////////////////////////////////////////////////////////// 
            Console.WriteLine("Valor máximo y mínimo para tipo de dato byte.");
            Console.WriteLine("Mínimo:" + byte.MinValue);
            Console.WriteLine("Máximo:" + byte.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor máximo y mínimo para tipo de dato sbyte.");
            Console.WriteLine("Mínimo:" + sbyte.MinValue);
            Console.WriteLine("Máximo:" + sbyte.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato short.");
            Console.WriteLine("Mínimo:" + short.MinValue);
            Console.WriteLine("Máximo:" + short.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato ushort.");
            Console.WriteLine("Mínimo:" + ushort.MinValue);
            Console.WriteLine("Máximo:" + ushort.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato int.");
            Console.WriteLine("Mínimo:" + int.MinValue);
            Console.WriteLine("Máximo:" + int.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato uint.");
            Console.WriteLine("Mínimo:" + uint.MinValue);
            Console.WriteLine("Máximo:" + uint.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato long.");
            Console.WriteLine("Mínimo:" + long.MinValue);
            Console.WriteLine("Máximo:" + long.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato ulong.");
            Console.WriteLine("Mínimo:" + ulong.MinValue);
            Console.WriteLine("Máximo:" + ulong.MaxValue);
            // /////////////////////////////////////////////////////////////////////
            Console.WriteLine("=================================================================");
            Console.ReadKey();


            // ////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato float.");
            Console.WriteLine("Mínimo:" + float.MinValue);
            Console.WriteLine("Máximo:" + float.MaxValue);
            // ////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato double.");
            Console.WriteLine("Mínimo:" + double.MinValue);
            Console.WriteLine("Máximo:" + double.MaxValue);
            // ////////////////////////////////////////////////////////////////////
            Console.WriteLine("Valor mínimo y máximo para tipo de dato decimal.");
            Console.WriteLine("Mínimo:" + decimal.MinValue);
            Console.WriteLine("Máximo:" + decimal.MaxValue);
            // ////////////////////////////////////////////////////////////////////
            Console.WriteLine("=================================================================");
            Console.ReadKey();

            // /////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo byte:" + sizeof(byte));
            Console.WriteLine("Bytes reservados para el tipo sbyte:" + sizeof(sbyte));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo short:" + sizeof(short));
            Console.WriteLine("Bytes reservados para el tipo ushort:" + sizeof(ushort));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo int:" + sizeof(int));
            Console.WriteLine("Bytes reservados para el tipo uint:" + sizeof(uint));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo long:" + sizeof(long));
            Console.WriteLine("Bytes reservados para el tipo ulong:" + sizeof(ulong));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo float:" + sizeof(float));
            Console.WriteLine("Bytes reservados para el tipo double:" + sizeof(double));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo decimal:" + sizeof(decimal));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo char:" + sizeof(char));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Bytes reservados para el tipo bool:" + sizeof(bool));
            // //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("=================================================================");
            Console.ReadKey();
       }
   }
}
