using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] daten = { 45, 10, 15, 4 };
            bool wiederholen;

            do
            {

                wiederholen = false;

                for (int index = 0; index < daten.Length - 1; index++)
                {

                    if (daten[index] > daten[index + 1])
                    {
                        double buffer = daten[index + 1];
                        //{ 45, 10, 15, 4 }
                        daten[index + 1] = daten[index];
                        //{ 45, 45, 15, 4 }
                        daten[index] = buffer;
                        //{ 10, 45, 15, 4 }
                        wiederholen = true;
                    }

                }

            } while (wiederholen == true);

            for (int i = 0; i <= daten.Length - 1; i++)
            {
                Console.WriteLine(daten[i]);
            }
        }
    }
}