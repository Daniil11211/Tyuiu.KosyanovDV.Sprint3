using Tyuiu.KosyanovDV.Sprint3.Task2.V25.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла do - while                               *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #25                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая         *");
            Console.WriteLine("* вычисляет сумму ряда по формуле, при n = 5                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");

            int x = 5;
            int startValue, endValue;

            Console.WriteLine("* endValue                                                      *");
            Console.WriteLine("* -----                                                         *");
            Console.WriteLine("* \\             4    2                                          *");
            Console.WriteLine("* /         ( ----- )                                           *");
            Console.WriteLine("* -----          n                                              *");
            Console.WriteLine("* startValue    k                                               *");
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