using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SychevAD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сычев А. Д. | АСОиУБ 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУБ 24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение угла f (0<f<360): ");
            double f = double.Parse(Console.ReadLine());
            if (f <= 0 || f >= 360)
            {
                Console.WriteLine("Значение угла f должно быть больше 0 и меньше 360!");
                Console.ReadLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Результат:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Полное количество часов:" + ds.AngleToHoursMinutes(f));
            Console.ReadLine();
        }
    }
}