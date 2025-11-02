using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class convertToTitles
    {
        public static string convertToTitle(int columnNumber)
        {
            string result = "";

            while (columnNumber > 0)
            {
                columnNumber--; // Excelda 1-indeks asosida, shuning uchun -1
                int remainder = columnNumber % 26;
                char letter = (char)('A' + remainder);
                result = letter + result;
                columnNumber /= 26;
            }

            return result;
        }
    }
}
