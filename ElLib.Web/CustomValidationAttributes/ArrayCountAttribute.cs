using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ElLib.Web.CustomValidationAttributes
{
    public class ArrayCountAttribute : ValidationAttribute
    {
        public int MinCount { get; set; }

        public ArrayCountAttribute()
        {
            
        }

        public ArrayCountAttribute(int minCount)
        {
            MinCount = minCount;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            var array = value as int[];

            return array.Count() >= MinCount;
        }
    }
}