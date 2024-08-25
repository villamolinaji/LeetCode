namespace DailyChallenge
{
	public class TreeNode
	{
		public int val { get; set; }
		public TreeNode? left { get; set; }
		public TreeNode? right { get; set; }
		public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public class Solution022
	{
		public IList<int> PostorderTraversal(TreeNode root)
		{
			var result = new List<int>();
			if (root == null)
			{
				return result;
			}

			var stack = new Stack<TreeNode>();
			TreeNode? lastVisited = null;
			var current = root;

			while (current != null ||
				stack.Count > 0)
			{
				if (current != null)
				{
					stack.Push(current);
					current = current.left;
				}
				else
				{
					var peekNode = stack.Peek();
					if (peekNode.right != null &&
						lastVisited != peekNode.right)
					{
						current = peekNode.right;
					}
					else
					{
						result.Add(peekNode.val);
						lastVisited = stack.Pop();
					}
				}
			}

			return result;
		}
	}
}
