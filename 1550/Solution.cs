using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            int count, i;
            count = i = 0;

            while (i < arr.Length && count != 3)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                i++;
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
