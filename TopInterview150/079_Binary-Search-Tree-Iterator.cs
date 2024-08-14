namespace TopInterview150
{
#pragma warning disable S101 // Types should be named in PascalCase
	public class BSTIterator
#pragma warning restore S101 // Types should be named in PascalCase
	{
		private Stack<TreeNode> Stack { get; set; }

		public BSTIterator(TreeNode root)
		{
			Stack = new Stack<TreeNode>();

			PushAllLeft(root);
		}

		public int Next()
		{
			var node = Stack.Pop();
			var result = node.val;

			if (node.right != null)
			{
				PushAllLeft(node.right);
			}

			return result;
		}

		public bool HasNext()
		{
			return Stack.Count > 0;
		}

		private void PushAllLeft(TreeNode? node)
		{
			while (node != null)
			{
				Stack.Push(node);

				node = node.left;
			}
		}
	}

}
