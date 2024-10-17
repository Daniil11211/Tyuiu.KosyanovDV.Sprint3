using Tyuiu.KosyanovDV.Sprint3.Task0.V1.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла for                                      *");
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #1                                                    *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу используя цикл for, которая                *");
            Console.WriteLine("* вычисляет сумму ряда по формуле, при x = 4                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");

            int x = 4;
            int startValue, endValue;

            Console.WriteLine("* endValue                                                      *");
            Console.WriteLine("* ------                                                        *");
            Console.WriteLine("* \\          2                                                  *");
            Console.WriteLine("* /        (x * i) + 1                                          *");
            Console.WriteLine("* ------                                                        *");
            Console.WriteLine("* startValue                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* x = {x}                                                         *");
            Console.Write("* Введите startValue: ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите endValue: ");
            endValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.GetSumSeries(x, startValue, endValue)} ");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}