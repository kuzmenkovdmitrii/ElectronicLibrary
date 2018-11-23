using System.Collections.Generic;
using System.Linq;

namespace Mapper
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
                var sourceProperty = typeof(T).GetProperties().FirstOrDefault(x => x.Name == outPropertyName);
                if (sourceProperty != null)
                {
                    var value = sourceProperty.GetValue(item, null);
                    outProperty.SetValue(mapped, value);
                }
            }

            return mapped;
        }

        public static ICollection<E> Map<T, E>(ICollection<T> items)
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
    }
}
