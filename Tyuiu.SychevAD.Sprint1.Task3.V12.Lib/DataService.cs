using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SychevAD.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double value, double valueTwo)
        {
            return Math.Round((value * valueTwo)/2, 3);
        }
    }
}
