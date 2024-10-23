using Tyuiu.KosyanovDV.Sprint3.Task6.V30.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                      *");
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, ищущая целые делители целых чисел на      *");
            Console.WriteLine("* отрезке [11;17]                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            int start = 11;
            int end = 17;
            Console.WriteLine($"* Отрезок  [{start};{end}]                                              *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.GetSumTheDivisors(start, end)} ");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}