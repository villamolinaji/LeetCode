namespace TopLiked100
{
	public class Solution067
	{
		public ListNode? DetectCycle(ListNode head)
		{
			var resultNode = new ListNode(-1);
			var visited = new HashSet<ListNode>();

			var currentNode = head;

			while (currentNode != null)
			{
				if (visited.Contains(currentNode))
				{
					resultNode = currentNode;
					break;
				}

				visited.Add(currentNode);
				currentNode = currentNode.next;
			}

			return resultNode.val == -1
				? null
				: resultNode;
		}
	}
}
