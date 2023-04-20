using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    internal class Mascota_Adoptada 
    {
        public  string  Nombre_Dueño { get; set; }
        public  int Pago_Mascota { get; set; }
        public  DateTime Fecha_Adopcion {get; set; }
        public  void mostrar()
        {
            Console.WriteLine("EL NOMBRE DEL DUEÑO :"+ Nombre_Dueño+","+" EL PAGO ES :" + Pago_Mascota+","+"FECHA DE ADOPCION ES :"+Fecha_Adopcion);
        }
    }
}
