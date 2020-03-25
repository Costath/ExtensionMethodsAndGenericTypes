using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public static class StringBuilder
    {
        /// <summary>
        /// Count the number of words separared by a space character in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CountWords(this string str)
        {
            string[] words = str.Split(' ');
            int numberOfWords;

            if (words.Last() != "")
            {
                numberOfWords = words.Count();
            }
            else
            {
                numberOfWords = words.Count() - 1;
            }

            return numberOfWords;
        }
    }
}
