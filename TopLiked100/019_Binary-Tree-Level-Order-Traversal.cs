namespace TopLiked100
{
	public class Solution019
	{
		public IList<IList<int>> LevelOrder(TreeNode root)
		{
			var result = new List<IList<int>>();

			if (root == null)
			{
				return result;
			}

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				var levelSize = queue.Count;
				var currentLevel = new List<int>();

				for (int i = 0; i < levelSize; i++)
				{
					var currentNode = queue.Dequeue();
					currentLevel.Add(currentNode.val);

					if (currentNode.left != null)
					{
						queue.Enqueue(currentNode.left);
					}
					if (currentNode.right != null)
					{
						queue.Enqueue(currentNode.right);
					}
				}

				result.Add(currentLevel);
			}

			return result;
		}
	}
}
