using Tyuiu.KosyanovDV.Sprint3.Task4.V19.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Использование операторов в циклах break, continue       *");
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #19                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить    *");
            Console.WriteLine("* значение функции y=x/(cos(x) + x)+0.5. При х = 0 прервать     *");
            Console.WriteLine("* цикл. Полученные значения перемножать.                        *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ФОРМУЛА:                                                      *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*          x                                                    *");
            Console.WriteLine("* y = ------------ + 0,5                                        *");
            Console.WriteLine("*     cos(x) + x                                                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ОТРЕЗОК, НА КОТОРОМ ОПРЕДЕЛЕНА ФУНКЦИЯ: x [-5; 5]             *");
            int startvalue = -5;
            int stopvalue = 5;
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.Calculate(startvalue, stopvalue)}                                                         *");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}