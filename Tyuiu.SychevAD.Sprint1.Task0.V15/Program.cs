using Tyuiu.SychevAD.Sprint1.Task0.V15.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task0.V15
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #1 | Выполнил: Сычев А. Д. | АСОиУб-24-1";

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
                Console.WriteLine("* Задание #0                                                              *");
                Console.WriteLine("* Вариант #15                                                             *");
                Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб-24-1                       *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2 * 2 - 8)        *");
                Console.WriteLine("* и печатает результат на экране.                                         *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* 20 - (2 * 2 - 8)                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.Calculate());

                Console.ReadLine();
            }
        }
    }
