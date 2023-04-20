using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    internal class Mascota_Perdidad : Mascota_Adoptada
    {
        public string Motivo { get; set; }
        public DateTime Fecha_Perdida { get; set; }
        public  void mostrar()
        {
            Console.WriteLine("EL MOTIVO ES : " + Motivo + "LA FECHA DE PERDICION" + Fecha_Perdida);
        }
    }
}
