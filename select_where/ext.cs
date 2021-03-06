﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_where
{
    public static class ext
    {
        public static IEnumerable<V> MySelect<T, V>(this IEnumerable<T> source, Func<T, V> func)
        {
            foreach (var value in source)
            {
                yield return func(value);
            }
            
        }

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            foreach (var value in source)
            {
                if (func(value))
                    yield return value;
            }
        } 
    }
}
