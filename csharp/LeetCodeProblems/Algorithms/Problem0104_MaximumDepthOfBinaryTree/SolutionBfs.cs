using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0104_MaximumDepthOfBinaryTree
{
    public class SolutionBfs : ISolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var maxDepth = 0;

            while (queue.Count > 0)
            {
                int childrenInQueue = queue.Count;
                while (childrenInQueue > 0)
                {
                    TreeNode child = queue.Dequeue();
                    if (child.left != null) queue.Enqueue(child.left);
                    if (child.right != null) queue.Enqueue(child.right);
                    childrenInQueue--;
                }
                maxDepth++;
            }
            return maxDepth;
        }
    }
}
