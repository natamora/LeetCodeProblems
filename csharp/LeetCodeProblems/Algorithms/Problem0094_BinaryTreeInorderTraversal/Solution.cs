using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0094_BinaryTreeInorderTraversal
{
    public class Solution : ISolution
    {
        // Recursive
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            Visit(root, list);
            return list;
        }

        public void Visit(TreeNode node, List<int> list)
        {
            if (node == null) return;
            Visit(node.left, list);
            list.Add(node.val);
            Visit(node.right, list);
        }

    }
}
