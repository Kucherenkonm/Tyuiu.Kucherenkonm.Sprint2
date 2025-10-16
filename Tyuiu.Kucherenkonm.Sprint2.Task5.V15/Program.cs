using Tyuiu.Kucherenkonm.Sprint2.Task5.V15.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:                        Оператор switch                            *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*    Написать программу, которая использует оператор switch вычисляет     *");
        Console.WriteLine("*               требуемое значение и возвращает результат.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер дня: ");
        int k = Convert.ToInt32(Console.ReadLine());
        string res;
        if ((k < 1) || (k > 365))
        {
            res = "Введено неверное значение";
        }
        else
        {
            res = "День недели: " + ds.FindDayName((int)k);
        }
            Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();

    }
}