using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    internal class Mascota : Mascota_Perdidad 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public void mostrar()
        {
            Console.WriteLine("EL NOMBRE DE LA MASCOTA ES : " + Nombre + "," + "LA EDAD DE LA MASCOTA :" + Edad + "," + "LA RAZA DE LA MASCOTA :" + Raza + "EL SEXO DE LA MASCOTA" + Sexo);
        }
    }
}
