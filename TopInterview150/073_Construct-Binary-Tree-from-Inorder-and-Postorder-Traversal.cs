namespace TopInterview150
{
	public class Solution073
	{
		public TreeNode? BuildTree(int[] inorder, int[] postorder)
		{
			var inorderIndexMap = new Dictionary<int, int>();

			for (int i = 0; i < inorder.Length; i++)
			{
				inorderIndexMap[inorder[i]] = i;
			}
			return BuildSubTree(postorder, 0, postorder.Length - 1, 0, inorder.Length - 1, inorderIndexMap);
		}

		private TreeNode? BuildSubTree(int[] postorder, int postorderStart, int postorderEnd, int inorderStart, int inorderEnd, Dictionary<int, int> inorderIndexMap)
		{
			if (postorderStart > postorderEnd ||
				inorderStart > inorderEnd)
			{
				return null;
			}

			var rootVal = postorder[postorderEnd];
			var rootNode = new TreeNode(rootVal);
			var inorderRootIndex = inorderIndexMap[rootVal];
			var rightTreeSize = inorderEnd - inorderRootIndex;

			rootNode.left = BuildSubTree(postorder, postorderStart, postorderEnd - rightTreeSize - 1, inorderStart, inorderRootIndex - 1, inorderIndexMap);
			rootNode.right = BuildSubTree(postorder, postorderEnd - rightTreeSize, postorderEnd - 1, inorderRootIndex + 1, inorderEnd, inorderIndexMap);

			return rootNode;
		}
	}
}
