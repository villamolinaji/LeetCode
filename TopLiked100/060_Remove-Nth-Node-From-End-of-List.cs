namespace TopLiked100
{
	public class Solution060
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			var resultNode = new ListNode(0);
			resultNode.next = head;
			var first = resultNode;
			var second = resultNode;

			for (int i = 0; i <= n; i++)
			{
				first = first?.next;
			}

			while (first != null)
			{
				first = first.next;
				second = second?.next;
			}

			if (second != null)
			{
				second.next = second.next?.next;
			}

			return resultNode.next;
		}
	}
}
