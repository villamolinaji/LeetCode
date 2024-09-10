namespace TopLiked100
{
	public class Solution016
	{
		public IList<int> InorderTraversal(TreeNode root)
		{
			var result = new List<int>();

			InorderRecursive(root, result);

			return result;
		}

		private void InorderRecursive(TreeNode? node, IList<int> result)
		{
			if (node == null)
			{
				return;
			}

			InorderRecursive(node.left, result);

			result.Add(node.val);

			InorderRecursive(node.right, result);
		}
	}
}
