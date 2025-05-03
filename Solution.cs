using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            int numberToCount, countInTops, countInBottoms, swapCount;
            numberToCount = countInTops = countInBottoms = swapCount = 0;

            for (int i = 1; i < 7; i++)
            {
                countInTops = 0;
                countInBottoms = 0;
                for (int j = 0; j < tops.Length; j++)
                {
                    if (tops[j] == i)
                    {
                        countInTops++;
                    }
                }
                for (int j = 0; j < bottoms.Length; j++)
                {
                    if (bottoms[j] == i)
                    {
                        countInBottoms++;
                    }
                }
                if (countInTops + countInBottoms >= tops.Length)
                {
                    numberToCount = i;
                    break;
                }
            }

            if (countInTops >= countInBottoms)
            {
                for (int i = 0; i < tops.Length; i++)
                {
                    if (bottoms[i] == numberToCount && tops[i] != numberToCount)
                    {
                        swapCount++;
                    }
                    else if (bottoms[i] != numberToCount && tops[i] != numberToCount)
                    {
                        swapCount = -1;
                        break;
                    }
                }
            }
            if (countInTops < countInBottoms)
            {
                for (int i = 0; i < tops.Length; i++)
                {
                    if (tops[i] == numberToCount && bottoms[i] != numberToCount)
                    {
                        swapCount++;
                    }
                    else if (bottoms[i] != numberToCount && tops[i] != numberToCount)
                    {
                        swapCount = -1;
                        break;
                    }
                }
            }

            return swapCount;
        }
    }
}
