using Tyuiu.Kucherenkonm.Sprint2.Task3.V19;
using Tyuiu.Kucherenkonm.Sprint2.Task3.V19.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:                   Вложенные операторы if - else                   *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*    Написать программу, которая вычисляет требуемое значение функции Y   *");
        Console.WriteLine("*   с использованием вложенных оператор if-else, где пользователь вводит  *");
        Console.WriteLine("*                      переменной X с клавиатуры.                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение функции y: " + y);
        Console.ReadKey();

    }
}