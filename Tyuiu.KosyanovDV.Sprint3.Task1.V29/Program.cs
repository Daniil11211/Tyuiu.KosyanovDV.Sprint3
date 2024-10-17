using Tyuiu.KosyanovDV.Sprint3.Task1.V29.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла while                                    *");
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #29                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу используя цикл while, которая              *");
            Console.WriteLine("* вычисляет сумму ряда по формуле, при x = 0,25                 *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");

            double x = 0.25;
            int startValue, endValue;

            Console.WriteLine("* endValue                                                      *");
            Console.WriteLine("* -----                                                         *");
            Console.WriteLine("* |   |       2                                                 *");
            Console.WriteLine("* |   |    (x * i) + 2                                          *");
            Console.WriteLine("* |   |                                                         *");
            Console.WriteLine("* startValue                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* x = {x}                                                      *");
            Console.Write("* Введите startValue: ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите endValue: ");
            endValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {Math.Round(ds.GetMultiplySeries(x, startValue, endValue), 2)} ");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}