using System.Collections.Generic;

namespace ElLib.Common
{
    public static class WordConverter
    {
        public static string GetPlural(string word)
        {
            int length = word.Length;
            List<string> forES = new List<string>() {"ch", "sh", "s", "ss", "x", "o"};
            List<string> forVES = new List<string>() {"f", "fe"};
            List<char> vowel = new List<char>() {'a', 'e', 'i', 'o', 'u', 'y'};

            if (forES.Contains(word.Substring(length - 2)) ||
                forES.Contains(word.Substring(length - 1)))
            {
                word = word + "es";
            }
            else if (forVES.Contains(word.Substring(length - 2)))
            {
                word = word.Remove(length - 2) + "ves";
            }
            else if (forVES.Contains(word.Substring(length - 1)))
            {
                word = word.Remove(length - 1) + "ves";
            }
            else if (word.EndsWith("y"))
            {
                if (!vowel.Contains(word[length - 2]))
                {
                    word = word.Remove(length - 1) + "ies";
                }
                else
                {
                    word = word + "s";
                }
            }
            else
            {
                word = word + "s";
            }

            return word;
        }
    }
}