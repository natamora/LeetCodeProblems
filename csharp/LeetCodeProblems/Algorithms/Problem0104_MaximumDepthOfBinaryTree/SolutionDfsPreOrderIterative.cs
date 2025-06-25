using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0104_MaximumDepthOfBinaryTree
{
    public class SolutionDfsPreOrderIterative : ISolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var stack = new Stack<(TreeNode, int)>();
            stack.Push((root, 1));
            var maxDepth = 0;

            while (stack.Count > 0)
            {
                var (curr, currDepth) = stack.Pop();
                if (maxDepth < currDepth) maxDepth = currDepth;

                if (curr.left != null) stack.Push((curr.left, currDepth + 1));
                if (curr.right != null) stack.Push((curr.right, currDepth + 1));

            }
            return maxDepth;
        }

    }
}
