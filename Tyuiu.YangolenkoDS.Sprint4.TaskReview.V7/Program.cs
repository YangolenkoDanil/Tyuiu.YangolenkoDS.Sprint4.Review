using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint4.TaskReview.V7.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.TaskReview.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 2;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #Review                                                                    *");
            Console.WriteLine("* Тема: SprintReview                                                                *");
            Console.WriteLine("* Задание #TaskReview                                                               *");
            Console.WriteLine("* Вариант #7                                                                        *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Преобразуйте строку в матрицу 4 на 2 и подсчитайте количество нечетных чисел      *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int[,] mtrx = new int[n, m];
            string value = "31415926";

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            int res = ds.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
