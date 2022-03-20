using System;

namespace Array_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            int[] daten = new int[10];
            {
                daten[0] = 19;
                daten[1] = 17;
                daten[2] = 13;


                for (int index = 3; index < daten.Length;index++)
                {
                    daten[index] = index * 10; 

                }
                foreach (int element in daten)
                {

                    Console.Write($" {element}\t");
                }
            }
           
        }










    }
    }
