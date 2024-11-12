using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SychevAD.Sprint1.Task7.V14.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сычев А. Д. | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУБ-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                 2");
            Console.WriteLine("     -x        5x           2");
            Console.WriteLine("z = 2     + --------  - cosx      + sin(2xy)");
            Console.WriteLine("                 3");
            Console.WriteLine("               3x");

            double x, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ: " + (ds.Calculate(x, y)));

            Console.ReadKey();
        }
    }
}