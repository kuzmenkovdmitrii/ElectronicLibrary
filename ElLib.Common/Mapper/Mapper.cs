using System;
using System.Collections.Generic;
using System.Linq;

namespace ElLib.Common.Mapper
{
    public static class Mapper
    {
        public static E Map<T, E>(T item)
            where T : class
            where E : class, new()
        {
            var mapped = new E();

            foreach (var outProperty in typeof(E).GetProperties())
            {
                string outPropertyName = outProperty.Name;

                var inProperty = typeof(T).GetProperties().FirstOrDefault(x => x.Name == outPropertyName);
                if (inProperty != null)
                {
                    if (CheckTypes(inProperty.PropertyType, outProperty.PropertyType) && inProperty != null)
                    {
                        var value = inProperty.GetValue(item, null);
                        outProperty.SetValue(mapped, value);
                    }
                }
            }

            return mapped;
        }

        public static IEnumerable<E> Map<T, E>(IEnumerable<T> items)
            where T : class, new()
            where E : class, new()
        {
            var mapped = new List<E>();

            foreach (var item in items)
            {
                mapped.Add(Map<T, E>(item));
            }

            return mapped;
        }

        private static bool CheckTypes(Type firstType, Type secondType)
        {
            if (firstType.Equals(secondType))
            {
                return true;
            }

            return false;
        }
    }
}
