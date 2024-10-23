using Tyuiu.KosyanovDV.Sprint3.Task7.V7.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту       *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #7                                                    *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции  *");
            Console.WriteLine("* на отрезке [-5; 5]                                            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* ФУНКЦИЯ:                                                      *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                   cos(x)                                      *");
            Console.WriteLine("* F(x) = cos(x) + ---------- - 3 * x                            *");
            Console.WriteLine("*                   x + 2                                       *");
            Console.WriteLine("*****************************************************************");
            int start = -5;
            int end = 5;
            Console.WriteLine($"* Отрезок  [{start};{end}]                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* +-----------+-----------+                                     *");
            Console.WriteLine("* |     X     |    F(X)   |                                     *");
            Console.WriteLine("* +-----------+-----------+                                     *");

            int len = ds.GetMassFunction(start, end).Length;

            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(start, end);

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("* | {0, 4:d}      |  {1, 6:f2}   |                                     *", start, valueArray[i]);
                start++;
            }
            Console.WriteLine("* +-----------+-----------+                                     *");

            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}