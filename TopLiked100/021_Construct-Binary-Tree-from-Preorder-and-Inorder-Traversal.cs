namespace TopLiked100
{
	public class Solution021
	{
		public TreeNode? BuildTree(int[] preorder, int[] inorder)
		{
			var inorderIndexMap = new Dictionary<int, int>();

			for (int i = 0; i < inorder.Length; i++)
			{
				inorderIndexMap[inorder[i]] = i;
			}
			return BuildSubTree(preorder, 0, preorder.Length - 1, 0, inorder.Length - 1, inorderIndexMap);
		}

		private TreeNode? BuildSubTree(int[] preorder, int preorderStart, int preorderEnd, int inorderStart, int inorderEnd, Dictionary<int, int> inorderIndexMap)
		{
			if (preorderStart > preorderEnd ||
				inorderStart > inorderEnd)
			{
				return null;
			}

			var rootVal = preorder[preorderStart];
			var rootNode = new TreeNode(rootVal);
			var inorderRootIndex = inorderIndexMap[rootVal];
			var leftTreeSize = inorderRootIndex - inorderStart;

			rootNode.left = BuildSubTree(preorder, preorderStart + 1, preorderStart + leftTreeSize, inorderStart, inorderRootIndex - 1, inorderIndexMap);
			rootNode.right = BuildSubTree(preorder, preorderStart + leftTreeSize + 1, preorderEnd, inorderRootIndex + 1, inorderEnd, inorderIndexMap);

			return rootNode;
		}
	}
}
