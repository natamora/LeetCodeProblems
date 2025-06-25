using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0108_ConvertSortedArrayToBinarySearchTree
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Construct(nums, 0, nums.Length - 1);
        }

        public TreeNode Construct(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = start + (end - start) / 2; // or (start+ end)/2
            TreeNode node = new TreeNode(nums[mid]);
            node.left = Construct(nums, start, mid - 1);
            node.right = Construct(nums, mid + 1, end);
            return node;
        }
    }
}
