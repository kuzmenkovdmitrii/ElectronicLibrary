using System;
using System.Collections.Generic;
using System.Linq;

namespace ElLib.Common.Mapper
{
    public static class Mapper
    {
        public static Output Map<Input, Output>(Input item)
            where Input : class
            where Output : class, new()
        {
            var mapped = new Output();

            foreach (var outProperty in typeof(Output).GetProperties())
            {
                string outPropertyName = outProperty.Name;

                var inProperty = typeof(Input).GetProperties().FirstOrDefault(x => x.Name == outPropertyName);
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

        public static IEnumerable<Output> Map<Input, Output>(IEnumerable<Input> items)
            where Input : class, new()
            where Output : class, new()
        {
            var mapped = new List<Output>();

            foreach (var item in items)
            {
                mapped.Add(Map<Input, Output>(item));
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
