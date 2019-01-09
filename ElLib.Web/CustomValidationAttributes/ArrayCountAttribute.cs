using System.ComponentModel.DataAnnotations;

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
            object[] array = value as object[];

            return array.Length >= MinCount ? true : false;
        }
    }
}