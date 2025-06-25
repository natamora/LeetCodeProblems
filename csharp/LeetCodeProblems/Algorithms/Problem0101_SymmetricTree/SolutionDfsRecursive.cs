using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0101_SymmetricTree
{
    public class SolutionDfsRecursive : ISolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Dfs(root.left, root.right);
        }

        public bool Dfs(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            if (node1?.val != node2?.val)
                return false;

            return Dfs(node1.left, node2.right) && Dfs(node1.right, node2.left);
        }

    }
}
