using System;
using System.Collections.Generic;
using System.Linq;

namespace Betrayal_House
{
    public static class Extensions
    {
        public static T RandomElement<T>(this IEnumerable<T> list, Random rng = null)
        {
            rng ??= new Random();
            return list.ElementAt(rng.Next(list.Count()));
        }
    }
}
