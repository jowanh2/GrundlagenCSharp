using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 45, 15, 4, 10 };
            bool var = true;
            int temp;
            int numLength = number.Length;


            Console.WriteLine("Arrays bevor Sortierung\n");
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);



            for (int i = 1; (i <= (numLength - 1)) && var; i++)
            {
                var = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[i])
                    {
                        temp = number[i];
                        number[i] = number[j + 1];
                        number[i + 1] = temp;
                        var = true;
                    }
                }
            }

            Console.WriteLine("Arrays nach Sortierung\n");


            foreach (int num in number)
            {
                Console.WriteLine("{0}", num);
            }
            Console.Read();
        }
    }
}