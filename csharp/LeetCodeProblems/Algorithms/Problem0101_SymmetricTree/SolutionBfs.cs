using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0101_SymmetricTree
{
    public class SolutionBfs : ISolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Bfs(root.left, root.right);
        }

        public bool Bfs(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1?.val != node2?.val) return false;

            Queue<(TreeNode, TreeNode)> queue = new Queue<(TreeNode, TreeNode)>();
            TreeNode curr1 = node1;
            TreeNode curr2 = node2;
            queue.Enqueue((curr1, curr2));

            while (queue.Count > 0)
            {
                (curr1, curr2) = queue.Dequeue();

                if (curr1?.val != curr2?.val) return false;

                if (curr1.left != null && curr2.right != null)
                {
                    queue.Enqueue((curr1.left, curr2.right));
                }
                else if (curr1.left != curr2.right && (curr1.left == null || curr2.right == null))
                    return false;

                if (curr1.right != null && curr2.left != null)
                {
                    queue.Enqueue((curr1.right, curr2.left));
                }
                else if (curr1.right != curr2.left && (curr1.right == null || curr2.left == null))
                    return false;

            }
            return true;
        }
    }
}
