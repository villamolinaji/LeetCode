namespace LeetCode75
{
	public class Solution34
	{
		public bool LeafSimilar(TreeNode root1, TreeNode root2)
		{
			var leaves1 = new List<int>();
			var leaves2 = new List<int>();

			EvaluateTree(root1, leaves1);
			EvaluateTree(root2, leaves2);

			return leaves1.SequenceEqual(leaves2);
		}

		private void EvaluateTree(TreeNode root, List<int> leaves)
		{
			if (root == null)
			{
				return;
			}

			if (root.left == null && root.right == null)
			{
				leaves.Add(root.val);
			}

			if (root.left != null)
			{
				EvaluateTree(root.left, leaves);
			}

			if (root.right != null)
			{
				EvaluateTree(root.right, leaves);
			}
		}
	}
}
