using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///CONDO CHUCA JAIR
namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Series");
            Console.WriteLine("--------INGRESE UN NUMERO -------------------");
            double  num = Double.Parse(Console.ReadLine());
            Console.WriteLine(Series.primer_serie(num));
            Console.WriteLine(Series.segunda_serie(num));
            Console.ReadKey();
        }
    }
}
