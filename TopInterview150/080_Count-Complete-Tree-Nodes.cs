namespace TopInterview150
{
	public class Solution080
	{
		public int CountNodes(TreeNode? root)
		{
			if (root == null)
			{
				return 0;
			}

			return 1 + CountNodes(root.left) + CountNodes(root.right);
		}
	}
}
