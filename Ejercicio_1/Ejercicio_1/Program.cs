using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CONDO CHUCA JAIR 
namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("-------------INGRESE NUMERO -------------------");
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine(Operacion.nume_letra(n));
            Console.ReadKey();
        }
    }
}
