using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CONDO CHUCA JAIR 
namespace Ejercicio_34
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            List<Mascota> listaMascota = new List<Mascota>();
            listaMascota.Add(new Mascota() { 
              Nombre = "LUFFY",
              Edad = 2,
              Raza = "CHAPI",
              Sexo ="Macho",
              Fecha_Adopcion = DateTime.Parse("18/02/2022"),
              Pago_Mascota = 1650,
            });

            listaMascota.Add(new Mascota()
            {
                Nombre = "Jack",
                Edad = 1,
                Raza = "Golden",
                Sexo = "Hembra",
                Fecha_Adopcion = DateTime.Parse("23/03/2020"),
                Pago_Mascota = 2250,
            });

            listaMascota.Add(new Mascota()
            {
                Nombre = "Simba",
                Edad = 2,
                Raza = "Labrador",
                Sexo = "Macho",
                Fecha_Adopcion = DateTime.Parse("01/04/2022"),
                Pago_Mascota = 1500,
            });

            listaMascota.Add(new Mascota()
            {
                Nombre = "Zoro",
                Edad = 5 ,
                Raza = "Boxer",
                Sexo = "Hembra",
                Fecha_Adopcion = DateTime.Parse("04/03/2021"),
                Pago_Mascota = 1600,
            });
            listaMascota.Add(new Mascota()
            {
                Nombre = "Aquiles",
                Edad = 2,
                Raza = "Chiwawa",
                Sexo = "Hembra",
                Fecha_Adopcion = DateTime.Parse("06/02/2021"),
                Pago_Mascota = 1300,
            }); 
            listaMascota.Add(new Mascota()
            {
                Nombre = "Boruto",
                Edad = 1,
                Raza = "Chiwawa",
                Sexo = "Hembra",
                Fecha_Adopcion = DateTime.Parse("03/05/2022"),
                Pago_Mascota = 1250,
            });
            listaMascota.Add(new Mascota()
            {
                Nombre = "Otis",
                Edad = 2,
                Raza = "Pator aleman",
                Sexo = "Hembra",
                Fecha_Adopcion = DateTime.Parse("20/10/2020"),
                Pago_Mascota = 1200,
            });
            listaMascota.Add(new Mascota()
            {
                Nombre = "Zeus",
                Edad = 2,
                Raza = "Golen",
                Sexo = "Macho",
                Fecha_Adopcion = DateTime.Parse("18/02/2021"),
                Pago_Mascota = 2400,
            });
            listaMascota.Add(new Mascota()
            {
                Nombre = "Bob",
                Edad = 3 ,
                Raza = "Siberiano",
                Sexo = "Macho",
                Fecha_Adopcion = DateTime.Parse("25/06/2020"),
                Pago_Mascota = 2600,
            });
            listaMascota.Add(new Mascota()
            {
                Nombre = "Sanji",
                Edad = 10 ,
                Raza = "Golden",
                Sexo = "Macho",
                Fecha_Adopcion = DateTime.Parse("30/04/2021"),
                Pago_Mascota = 2500,
                                
            });
            Console.WriteLine("--------------LISTA DE MASCOTAS ------------------");
            foreach(var mascota in listaMascota)
            {
                Console.WriteLine("NOMBRE :" + mascota.Nombre + "EDAD :" + mascota.Edad + "RAZA :" + mascota.Raza + "SEXO : " + mascota.Sexo + "FECHA DE ADOPCION:" + mascota.Fecha_Adopcion + "PRECIO :" + mascota.Pago_Mascota);
            }
            //promedio de edades de las mascotas 
            double promedio = PromEdad(listaMascota);
            Console.WriteLine("\n----------EL PROMEDIO DE LAS EDADES ES --------------------" + promedio);
            //promedio de los pagos 
            double prome_pago = prom_Pago(listaMascota);
            Console.WriteLine("\n----------EL PROMEDIO DE LOS PAGOS --------------------" + prome_pago);
            //consultar quiene es Chiwawa
            Raza_Chiwawa(listaMascota);
            // consultar menor a dos años
            Edad_prom(listaMascota);
            Console.ReadKey();
        }

        private static void Edad_prom(List<Mascota> listaMascota)
        {
            var mostrar = (from mascota in listaMascota
                           where mascota.Fecha_Adopcion.Year >= 2020 && mascota.Fecha_Adopcion.Year < 2022
                           select mascota.Nombre);
            Console.WriteLine("\n----------MASCOTAS MENORES DE 2 AÑOS--------------------");
            foreach (var mascot in mostrar)
            {
                Console.WriteLine(mascot);
            }

        }

        private static void Raza_Chiwawa(List<Mascota> listaMascota)
        {
            var Mostrar = (from mascota in listaMascota
                           where mascota.Raza == "Chiwawa" && mascota.Sexo == "Hembra"
                           select mascota.Nombre
                           );
            Console.WriteLine("\n----------RAZAS CHIWAWA--------------------" );
            foreach (var item in Mostrar)
            {
                Console.WriteLine(item);
            }
        }

        private static double prom_Pago(List<Mascota> listaMascota)
        {
            int Totalpago = listaMascota.Sum(x => x.Pago_Mascota);
            int TotalMascotas = listaMascota.Count;
            return (double)Totalpago / TotalMascotas;
        }

        private static double PromEdad(List<Mascota> listaMascota)
        {
            int TotalEdad = listaMascota.Sum(x => x.Edad);
            int TotalMascotas = listaMascota.Count;
            return (double)TotalEdad / TotalMascotas;
        }
    }
}
