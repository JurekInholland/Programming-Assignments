using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    static class Extensions
    {
        /// <summary>
        /// Get all indexes of a search string within a string, not only the first occurence
        /// Taken from stackoverflow: https://stackoverflow.com/a/16062510
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchstring"></param>
        /// <returns></returns>
        public static IEnumerable<int> AllIndexesOf(this string str, string searchstring)
        {
            int minIndex = str.IndexOf(searchstring);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length);
            }
        }

    }
}
