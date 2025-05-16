using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            int numberOfVowels = 0;

            for (int i = left; i <= right; i++)
            {
                char currentStart = words[i][0];
                char currentEnd = words[i][words[i].Length - 1];
                if (currentStart == 'a' || currentStart == 'e' || currentStart == 'i' || currentStart == 'o' || currentStart == 'u')
                {
                    if (currentEnd == 'a' || currentEnd == 'e' || currentEnd == 'i' || currentEnd == 'o' || currentEnd == 'u')
                    {
                        numberOfVowels++;
                    }
                }
            }

            return numberOfVowels;
        }
    }
}
