using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            int n = score.Length;
            int[] ordered_score = new int[n];
            string[] preview_output = new string[n];
            string[] output = new string[n];

            for (int i = 0; i < n; i++)
            {
                ordered_score[i] = score[i];

                switch (i)
                {
                    case 0:
                        preview_output[i] = "Gold Medal";
                        break;
                    case 1:
                        preview_output[i] = "Silver Medal";
                        break;
                    case 2:
                        preview_output[i] = "Bronze Medal";
                        break;
                    default:
                        preview_output[i] = (i + 1).ToString();
                        break;
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ordered_score[i] < ordered_score[j])
                    {
                        int bigger = ordered_score[j];
                        ordered_score[j] = ordered_score[i];
                        ordered_score[i] = bigger;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (score[i] == ordered_score[j])
                    {
                        output[i] = preview_output[j];
                    }
                }
            }

            return output;
        }
    }
}
