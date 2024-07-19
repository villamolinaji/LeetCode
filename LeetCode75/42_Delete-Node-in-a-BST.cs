namespace LeetCode75
{
	public class Solution42
	{
		public TreeNode? DeleteNode(TreeNode? root, int key)
		{
			if (root is null)
			{
				return root;
			}

			if (key < root.val)
			{
				root.left = DeleteNode(root.left, key);
			}
			else if (key > root.val)
			{
				root.right = DeleteNode(root.right, key);
			}
			else
			{
				if (root.left is null &&
					root.right is null)
				{
					root = null;
				}
				else if (root.left is null ||
					root.right is null)
				{
					root = root.left is not null
						? root.left :
						root.right;
				}
				else
				{
					TreeNode nodeAux = root.right;
					while (nodeAux.left != null)
					{
						nodeAux = nodeAux.left;
					}

					root.val = nodeAux.val;
					root.right = DeleteNode(root.right, nodeAux.val);
				}
			}

			return root;
		}
	}
}
