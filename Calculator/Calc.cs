using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        //создадим метод для вычисления суммы
        public int Sum (int a,int b)
            { 
            return a + b; 
            }
        //создадим метод максимального значения
        public double Max(int a, int b)
        {
            double c = Math.Max(a, b);
            return c;
        }
    }

}
