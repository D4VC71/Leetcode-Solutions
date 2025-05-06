using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }
    }
}
