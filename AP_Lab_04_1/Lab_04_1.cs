using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine($"Отримана першим способом сума \"S\": {S};");
            ii = 1; S = 0;

            // Спосіб 2: do{ … } while(…)
            do
            {
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));
                ii++;
            }
            while (ii <= N);

            Console.WriteLine($"отримана другим способом сума \"S\": {S};");
            S = 0;

            // Спосіб 3: for(…; …; n++) {… }
            for (ii = 1; ii <= N; ii++) 
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));

            Console.WriteLine($"отримана третім способом сума \"S\": {S};");
            S = 0;

            // Спосіб 4: for(…; …; n--) {… }
            for (ii = N; ii >= 1; ii--)
                S += Math.Sqrt(1 + Math.Pow(Math.Cos(Math.Sin(ii)), 2)) / (1 + Math.Pow(Math.Sin(Math.Cos(ii)), 2));

            Console.WriteLine($"отримана четвертим способом сума \"S\": {S}");

            Console.ReadLine();
        }
    }
}
