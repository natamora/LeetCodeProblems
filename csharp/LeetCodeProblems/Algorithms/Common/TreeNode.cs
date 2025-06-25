using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Algorithms.Common
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode FromList(List<int?> values)
        {
            if (values == null || values.Count == 0 || values[0] == null)
                return null;

            var root = new TreeNode(values[0].Value);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int index = 1;

            while (index < values.Count)
            {
                var current = queue.Dequeue();

                // Left child
                if (index < values.Count && values[index] != null)
                {
                    current.left = new TreeNode(values[index].Value);
                    queue.Enqueue(current.left);
                }
                index++;

                // Right child
                if (index < values.Count && values[index] != null)
                {
                    current.right = new TreeNode(values[index].Value);
                    queue.Enqueue(current.right);
                }
                index++;
            }

            return root;
        }

        public static List<int?> ToList(TreeNode? root)
        {
            var result = new List<int?>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    result.Add(null);
                    continue;
                }

                result.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                if (result[i] != null) break;
                result.RemoveAt(i);
            }

            return result;
        }

    }
}
