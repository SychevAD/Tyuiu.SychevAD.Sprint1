using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SychevAD.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        /// <summary>
        /// Возвращает полное количество часов, прошедших с начала суток (первой половины дня) по углу поворота часовой стрелки.
        /// </summary>
        /// <param name="f">Угол поворота часовой стрелки в градусах, 0 &lt; f &lt; 360</param>
        /// <returns>Целое количество прошедших часов (0..11)</returns>
        public int AngleToHours(double f)
        {
            if (f <= 0 || f >= 360)
                throw new ArgumentOutOfRangeException(nameof(f), "Угол должен быть в диапазоне (0; 360)");

            // Часовая стрелка за 12 часов проходит 360 градусов
            // Значит 1 час = 30 градусов
            // Кол-во часов = угол / 30, берем только полные часы => Math.Floor
            int hours = (int)Math.Floor(f / 30.0);
            return hours;
        }

        /// <summary>
        /// Возвращает полное количество часов и минут по углу поворота часовой стрелки.
        /// </summary>
        /// <param name="f">Угол в градусах</param>
        /// <param name="hours">Выходной параметр - часы</param>
        /// <param name="minutes">Выходной параметр - минуты</param>
        public void AngleToHoursMinutes(double f, out int hours, out int minutes)
        {
            if (f <= 0 || f >= 360)
                throw new ArgumentOutOfRangeException(nameof(f), "Угол должен быть в диапазоне (0; 360)");

            double totalHours = (f / 360.0) * 12.0;
            hours = (int)Math.Floor(totalHours);
            minutes = (int)Math.Floor((totalHours - hours) * 60);
        }
    }
}