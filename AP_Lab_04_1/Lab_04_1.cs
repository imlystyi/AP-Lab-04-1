// Lab_04_1.cs
// Якубовський Владислав
// Лабораторна робота № 4.1
// Цикли.
// Варіант 24
using System;

namespace AP_Lab_04_1
{
    internal class Lab_04_1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            int ii = 1, N;
            double S = 0;

            Console.Write("Введіть значення для \"N\": ");

            N = int.Parse(Console.ReadLine());

            // Спосіб 1: while(…) { … }
            while (ii <= N)
            {
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));
                ii++;
            }

            Console.WriteLine($"Отримана першим способом сума \"S\":\t{S}");
            ii = 1; S = 0;

            // Спосіб 2: do{ … } while(…)
            do
            {
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));
                ii++;
            }
            while (ii <= N);

            Console.WriteLine($"Отримана другим способом сума \"S\":\t{S}");
            S = 0;

            // Спосіб 3: for(…; …; n++) {… }
            for (ii = 1; ii <= N; ii++) 
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));

            Console.WriteLine($"Отримана третім способом сума \"S\":\t{S}");
            S = 0;

            // Спосіб 4: for(…; …; n--) {… }
            for (ii = N; ii >= 1; ii--)
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));

            Console.WriteLine($"Отримана четвертим способом сума \"S\":\t{S}");

            Console.ReadLine();
        }
    }
}