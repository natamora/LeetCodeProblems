using LeetCodeProblems.Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Problem0101_SymmetricTree
{
    public class SolutionDfsInOrder : ISolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return InOrderDFS(root.left, root.right);

        }        
        public bool InOrderDFS(TreeNode node1, TreeNode node2)
        {
            Stack<(TreeNode, TreeNode)> stack = new Stack<(TreeNode, TreeNode)>();
            TreeNode curr1 = node1;
            TreeNode curr2 = node2;

            if (node1 == null && node2 == null)
                return true;
            if (node1?.val != node2?.val)
                return false;

            while (stack.Count > 0 || curr1 != null || curr2 != null)
            {
                while (curr1 != null && curr2 != null)
                {
                    stack.Push((curr1, curr2));
                    curr1 = curr1.left;
                    curr2 = curr2.right;
                }

                if (curr1 == null && curr2 == null)
                {
                    (curr1, curr2) = stack.Pop();
                    if (curr1.val != curr2.val) return false;
                    curr1 = curr1.right;
                    curr2 = curr2.left;
                }
                else return false;
            }
            return true;
        }
    }
}
