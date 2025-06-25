using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0094_BinaryTreeInorderTraversal
{
    public class Solution2 : ISolution
    {
        // Iterate using stack
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;

            while (stack.Count > 0 || curr != null)
            {
                // while curr not null, put node on stack and go to the left child
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                // if curr == null then pop node from stack and add to list, then go visit right node
                curr = stack.Pop();
                list.Add(curr.val);
                curr = curr.right;
            }
            return list;
        }
    }
}
