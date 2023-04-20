using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    static class Series
    {
        public static double primer_serie(double numero)
        {
            int res = 0;
            for (res = 0; res <= numero; res++)
            {
                int com;
                com = res*res;
                Console.Write(com + ",");

            }
            return res;
        }
        public static double  segunda_serie(double num)
        {
            double nume = 2;
            double res = 1;
            for (double con = res; con <=num; con++)
            { 
                double ser;
                ser = Math.Pow(nume, con);
                Console.Write(ser + ",");

            }
            return res;
        }
    }
}
