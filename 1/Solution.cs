using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indices = { 0, 0 };

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indices[0] = i;
                        indices[1] = j;
                        break;
                    }
                }
            }

            return indices;
        }
    }
}
