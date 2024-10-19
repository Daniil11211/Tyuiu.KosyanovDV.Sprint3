using Tyuiu.KosyanovDV.Sprint3.Task5.V30.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Вложенные циклы                                         *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Вычислить сумму сумм при x = 2                                *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ФОРМУЛА:                                                      *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* end1                                                          *");
            Console.WriteLine("* __________  end2                                              *");
            Console.WriteLine("* \\         ________                                            *");
            Console.WriteLine("*  \\        \\                                                   *");
            Console.WriteLine("*   \\        \\          3                                       *");
            Console.WriteLine("*   /        /      (x  - start2) + x                           *");
            Console.WriteLine("*  /        /                                                   *");
            Console.WriteLine("* /         --------                                            *");
            Console.WriteLine("* ---------- start2                                             *");
            Console.WriteLine("* start1                                                        *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            int start1, start2, end1, end2, x;
            x = 2;
            Console.WriteLine($"* x = {x}                                                         *");
            Console.Write("* Введите start1: ");
            start1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите start2: ");
            start2 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("* Введите end1: ");
            end1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите end2: ");
            end2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.GetSumSumSeries(x, start1, start2, end1, end2)}           ");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}