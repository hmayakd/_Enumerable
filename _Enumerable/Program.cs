using System;
using System.Collections.Generic;

namespace _Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int> { -3, -2, -1, 0, 1, 2, 3 };
            var newMarks = marks._First();
            newMarks = marks._Add(2);
            newMarks= marks._Sub(1);
            newMarks = marks._Mul(10);
            newMarks = newMarks._Div(3);
            newMarks = newMarks._MinMax(3,10);
        }
    }
}
