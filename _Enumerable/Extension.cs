using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _Enumerable
{
    public static class _Extension
    {
        public static IEnumerable<int> _First(this IEnumerable<int> source)
        {
            if (source == null) throw new ArgumentNullException();
            foreach (var item in source)
            {
                yield return item;
                yield break;
            }
        }
        public static IEnumerable<int> _MinMax(this IEnumerable<int> source, int min)
        {
            foreach (var item in source)
            {
                if (item > min)
                    yield return item;
            }
        }
        public static IEnumerable<int> _MinMax(this IEnumerable<int> source, int min, int max)
        {
            foreach (var item in source)
            {
                if ((item > min) && (item < max))
                    yield return item;
            }
        }
        public static IEnumerable<int> _Add(this IEnumerable<int> source, int factor)
        {
            foreach (var item in source)
            {
                yield return item + factor;
            }
        }
        public static IEnumerable<int> _Sub(this IEnumerable<int> source, int factor)
        {
            foreach (var item in source)
            {
                yield return item - factor;
            }
        }
        public static IEnumerable<int> _Mul(this IEnumerable<int> source, int factor)
        {
            if (source == null) throw new ArgumentNullException();
            foreach (var item in source)
            {
                yield return item * factor;
            }
        }
        public static IEnumerable<int> _Div(this IEnumerable<int> source, int factor)
        {
            if (source == null) throw new ArgumentNullException();
            foreach (var item in source)
            {
                yield return item / factor;
            }
        }
    }
}
