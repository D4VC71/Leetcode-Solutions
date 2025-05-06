using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            int a, b, n, swapCount;
            n = dominoes.GetLength(0);
            swapCount = 0;
            Dictionary<string, int> dominoPairs = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                a = dominoes[i][0];
                b = dominoes[i][1];
                if (a > b)
                {
                    int c = dominoes[i][0];
                    a = b;
                    b = c;
                }
                if (!dominoPairs.ContainsKey($"[{a},${b}]"))
                {
                    dominoPairs.Add($"[{a},${b}]", 1);
                }
                else
                {
                    dominoPairs[$"[{a},${b}]"] += 1;
                }
            }

            foreach (var item in dominoPairs)
            {
                float division = (float)((item.Value - 1.0f) / 2.0f);
                swapCount += Convert.ToInt32(item.Value * division);
            }

            return swapCount;
        }
    }
}
