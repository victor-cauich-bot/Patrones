using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesdediceño
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> arrayFechas = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\ruta\fechas.txt");
            System.Console.WriteLine("Contenido del archivo = ");
            DateTime FechaActual = DateTime.Now;
        

            foreach (string line in lines)
            {
                string[] palabras = line.Split(',');
                
                DateTime FechaDato = Convert.ToDateTime(palabras[1]);
                if (FechaDato< FechaActual)
                {
                    Console.WriteLine(palabras[0] + " Ocurrio en: " +palabras[1]);
                    string comparacion = "años: " + (FechaActual.Year - FechaDato.Year).ToString() + " meses:" + (Math.Abs(FechaActual.Month - FechaDato.Month)) + " dias: " + (FechaActual.Day - FechaDato.Day) + " horas: " + (FechaActual.Hour - FechaDato.Hour);
                    
                    Console.WriteLine (comparacion);
                }
                else
                {
                    Console.WriteLine(palabras[0] + " Ocurrira en: " + palabras[1]);
                    string comparacion = "años: " + (FechaDato.Year - FechaActual.Year).ToString() + " meses:" + (Math.Abs(FechaDato.Month - FechaActual.Month)) + " dias: " + (FechaDato.Day - FechaActual.Day) + " horas: " + (FechaActual.Hour - FechaDato.Hour);
                }

                
            }




            Console.WriteLine("Presione cualquier tecla para salir.");
            System.Console.ReadKey();
        }
    }
}
