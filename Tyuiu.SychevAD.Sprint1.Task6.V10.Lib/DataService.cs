using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SychevAD.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    words[i] = words[i].Remove(words[i].Length / 2, 1);
                }
            }
            string res = string.Join(" ", words);
            return res;
        }
    }
}