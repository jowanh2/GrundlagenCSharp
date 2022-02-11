using System;

namespace Finanztabelle
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("{0,3} {1,10} {2,8} {3,10} {4,8}","Jahr","Guthaben","Zinsen","k.zinsen","bilanz");

            Console.WriteLine(" ");

            double k = 0, j = 0, P = 0;
            double kz = 0, b = 0;




            Console.WriteLine("Geben sie ihre Kapital ein");
            k = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("Geben sie ihre Prozentsatz ein");
            P = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Wieviele Jahre soll des dauern?");
            j = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("{0,3} {1,10} {2,8} {3,10} {4,8}", "Jahr", "Guthaben", "Zinsen", "k.zinsen", "bilanz");



            for (int i = 0; i <= 60; i++)
            {
               Console.Write("-");
            }
            Console.WriteLine("");
            j--;
            for (int J = 0; J<=j;J++)
            {
            kz = kz + k * (P / 100);
            b = b + k;


            Console.WriteLine("{0,3}| {1,9:F2}Euro| {2,6:F2}Euro| {3,8:F2}Euro| {4,6:F2}Euro", J, k, k* (P/100), kz, b);
            k = k + (k * (P / 100));
            }
          


            for (int i = 0; i <= 60; i++)
            {
             Console.Write("-");
            }
        }


        }
    }

