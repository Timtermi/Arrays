using System;

namespace Aufgabe_3
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
                int temp = daten[0];      
                
                for (int index = 0; index < daten.Length-1; index++)
                {
                   
                        daten[index] = daten[index + 1];
             

                }
                
           
                daten[daten.Length - 1] = temp;
                foreach (int element in daten)
                {

                    Console.Write($" {element}\t");


                }
                


            }
        }
    }
}
