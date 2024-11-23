using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Opgave56 Lav et program der finder gennemsnittet af en række temperaturer målt over en 7 dages periode.

            Brug array.

            Avanceret! Brug evt. to Arrays. Ét til temperaturen og ét til ugedagenes navne. 
            Så kan du udskrive ugedag og temperatur sammen.

           Koden skal indeholde kommentarer.*/


            double sum = 0; // angiver double sum til at angive summen



            double[] temperatur = new double[7];
            string[] ugedage = { "mandag", "tirsdag", "onsdag", "torsdag", "fredag", "lørdag", "søndag" };

            //Array løbes igennem
            for (int i = 0; i < ugedage.Length; i++)

            {

                Console.Write("Indtast temperaturen for ugedagen {0}: ", ugedage[i]);
                temperatur[i] = Convert.ToDouble(Console.ReadLine());

                sum = sum + temperatur[i];

            }


            // Arrayet løbes igennem een gang til og udskriver samtlige index
            Console.Clear();
            for (int i = 0; i < ugedage.Length; i++)

            {

                // til sidst beregnes gennmsnittet

                Console.WriteLine($"temperaturen for {ugedage[i]} er {temperatur[i]}");
            }

            Console.Write($"Gennemsnittstemperaturen er {sum / 7:n}");

            ;

            Console.ReadKey();




        }
    }
}
