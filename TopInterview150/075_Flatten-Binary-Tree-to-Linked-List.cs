namespace TopInterview150
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

	public class Solution075
	{
		public void Flatten(TreeNode? root)
		{
			if (root == null)
			{
				return;
			}

			Flatten(root.left);
			Flatten(root.right);

			var leftSubtree = root.left;
			var rightSubtree = root.right;

			root.left = null;
			root.right = leftSubtree;

			var current = root;
			while (current.right != null)
			{
				current = current.right;
			}
			current.right = rightSubtree;
		}
	}
}
