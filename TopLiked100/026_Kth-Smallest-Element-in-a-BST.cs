namespace TopLiked100
{
	public class Solution026
	{
		public int KthSmallest(TreeNode root, int k)
		{
			var nodes = new List<int>();

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				var node = queue.Dequeue();
				nodes.Add(node.val);

				if (node.left != null)
				{
					queue.Enqueue(node.left);
				}

				if (node.right != null)
				{
					queue.Enqueue(node.right);
				}
			}

			nodes.Sort();

			return nodes[k - 1];
		}
	}
}
