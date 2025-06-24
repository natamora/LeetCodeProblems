using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0015_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            // sort input array
            Array.Sort(nums);
            HashSet<string> set = new HashSet<string>();

            // iterate through all elements in Tab with i variable
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                // create two pointers: j and k
                int j = i + 1;
                int k = nums.Length - 1;
                // Loop through 
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        string s = nums[i] + "," + nums[j] + "," + nums[k];
                        if (!set.Contains(s))
                        {
                            set.Add(nums[i] + "," + nums[j] + "," + nums[k]);
                            res.Add(new List<int> { nums[i], nums[j], nums[k] });
                        }

                        // inc j and k 
                        j++; k--;
                        // without set u can just skip duplicates
                        //while(j<k && nums[j]==nums[j-1])j++;
                        //while(j<k && nums[k]==nums[k+1])k--;
                    }
                    else if (sum < 0) j++;
                    else if (sum > 0) k--;
                }
            }
            return res;
        }
    }
}
