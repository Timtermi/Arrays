using System;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daten = new int[10];
            {
                daten[0] = 19 * 19;
                daten[1] = 17 * 17;
                daten[2] = 13 * 13;


                for (int index = 3; index < daten.Length; index++)
                {


                    daten[index] = index * 10 * index * 10;


                }
                foreach (int element in daten)
                {

                    Console.Write($" {element}\t");


                }
                Console.WriteLine();
               

                Console.Write("geben sie einenen index ein: ");
                int stelle = Convert.ToInt32(Console.ReadLine());
                for (int index = stelle; index < daten.Length - 1; index++)
                {

                    daten[index] = daten[index + 1];


                }
                Console.WriteLine("geben sie eine zahl ein: ");
                daten[daten.Length - 1] = Convert.ToInt32(Console.ReadLine());

            
                foreach (int element in daten)
                {

                    Console.Write($" {element}\t");


                }



            }
        }
    }
}
