namespace TopInterview150
{
	public class Solution085
	{
		public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
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

			for (int i = 0; i < result.Count; i++)
			{
				if (i % 2 == 1)
				{
					result[i] = result[i].Reverse().ToList();
				}
			}

			return result;
		}
	}
}
