namespace TopLiked100
{
	public class Solution017
	{
		public bool IsValidBST(TreeNode root)
		{
			return Validate(root, null, null);
		}

		private bool Validate(TreeNode? node, int? lower, int? upper)
		{
			if (node == null)
			{
				return true;
			}

			var nodeVal = node.val;
			if (lower.HasValue &&
				nodeVal <= lower.Value)
			{
				return false;
			}
			if (upper.HasValue &&
				nodeVal >= upper.Value)
			{
				return false;
			}

			if (!Validate(node.right, nodeVal, upper))
			{
				return false;
			}
			if (!Validate(node.left, lower, nodeVal))
			{
				return false;
			}

			return true;
		}
	}
}
