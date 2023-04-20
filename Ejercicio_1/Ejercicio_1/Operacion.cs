using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CONDO CHUCA JAIR 
namespace Ejercicio_1
{
     static class Operacion
    {
        public static string mostrar(string num)
        {
           
            string res, dec = "";
            Int64 enteros;
            int decimales;
            double numero;
            try
            {
                numero = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }
            enteros = Convert.ToInt64(Math.Truncate(numero));
            decimales = Convert.ToInt32(Math.Round((numero - enteros) * 100, 2));
            if (decimales > 0)
            {
                dec =  decimales.ToString() ;
            }
            res = nume_letra(Convert.ToDouble(enteros))+ dec;
            return res;
        }
        public static string nume_letra(double num)
        {
            
            string num2 = "";
            num = Math.Truncate(num);
            if (num == 0) num2 = " cero ";
            else if (num == 1) num2 = " uno ";
            else if (num == 2) num2 = " dos ";
            else if (num == 3) num2 = " tres ";
            else if (num == 4) num2 = " cuatro ";
            else if (num == 5) num2 = " cinco ";
            else if (num == 6) num2 = " seis ";
            else if (num == 7) num2 = " siete ";
            else if (num == 8) num2 = " ocho ";
            else if (num == 9) num2 = " nueve ";
            else if (num == 10) num2 =" diez ";
            else if (num == 11) num2 =" once ";
            else if (num == 12) num2 = " doce ";
            else if (num == 13) num2 = " trece ";
            else if (num == 14) num2 = " catorce ";
            else if (num == 15) num2 = " quince ";
            else if (num < 20) num2 = " diece " + nume_letra(num - 10);
            else if (num == 20) num2 = " veinte ";
            else if (num < 30) num2 = " diece " + nume_letra(num - 20);
            else if (num == 20) num2 = " treinta ";
            else if (num == 40) num2 = " cuarenta ";
            else if (num == 50) num2 = " cincuenta ";
            else if (num == 60) num2 = " sesenta ";
            else if (num == 70) num2 = " setenta ";
            else if (num == 80) num2 = " ochenta ";
            else if (num == 90) num2 = " noventa ";
            else if (num < 100) num2 = nume_letra(Math.Truncate(num / 10) * 10) + " y " + nume_letra(num % 10);
            else if (num == 100) num2 = " cien ";
            else if (num < 200) num2 = "ciento" + nume_letra(num - 100);
            else if ((num == 200) || (num == 300) || (num == 400) || (num == 600) || (num == 800)) num2 = nume_letra(Math.Truncate(num / 100)) + "cientos";
            else if (num == 500) num2 = "quinientos";
            else if (num == 700) num2 = "setecientos";
            else if (num == 900) num2 = "novecientos";
            else if (num < 1000) num2 = nume_letra(Math.Truncate(num / 100) * 100) + " " + nume_letra(num % 100);
            else if (num == 1000) num2 = "mil";
            return num2;




        }


    }
}
