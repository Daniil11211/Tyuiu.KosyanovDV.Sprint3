using Tyuiu.KosyanovDV.Sprint3.Task3.V21.Lib;

namespace Tyuiu.KosyanovDV.Sprint3.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Косьянов Д.В. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                  *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #21                                                   *");
            Console.WriteLine("* Выполнил : Косьянов Даниил Васильевич | ПКТб-24-1             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву e              *");
            Console.WriteLine("* в строке: f3g5ht g4j 34kg4                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");

            string str = "f3g5ht g4j 34kg4";
            char item = 'e';

            Console.WriteLine($"* Cтрока = {str}                                     *");
            Console.WriteLine($"* Элемент, который будет ставится вмесо цифр = {item}                *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* {ds.ReplaceNumOnChar(str, item)}                                              *");
            Console.WriteLine("*****************************************************************");



            Console.ReadKey();

        }
    }
}