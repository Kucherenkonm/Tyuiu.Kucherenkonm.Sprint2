using Tyuiu.Kucherenkonm.Sprint2.Task2.V14.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:          Оператор if – полная и короткая форма записи             *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("*             и вычисляет находится ли точка с координатами               *");
        Console.WriteLine("*                     X,Y в заштрихованной области                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение х: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        { Console.WriteLine("Точка находится в выделенной области"); }
        else { Console.WriteLine("Точка не находится в выделенной области"); }
            Console.ReadKey();
    }
}
