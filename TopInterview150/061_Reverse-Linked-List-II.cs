namespace TopInterview150
{
	public class Solution061
	{
		public ListNode? ReverseBetween(ListNode head, int left, int right)
		{
			if (head == null || left == right)
			{
				return head;
			}

			var dummy = new ListNode(0);
			dummy.next = head;
			var leftPrev = dummy;

			for (int i = 1; i < left; i++)
			{
				leftPrev = leftPrev?.next;
			}

			var leftNode = leftPrev?.next;

			ListNode? prev = null;
			var curr = leftNode;

			for (int i = 0; i <= right - left; i++)
			{
				var next = curr?.next;
				if (curr != null)
				{
					curr.next = prev;
				}
				prev = curr;
				curr = next;
			}

			if (leftPrev != null)
			{
				leftPrev.next = prev;
			}
			if (leftNode != null)
			{
				leftNode.next = curr;
			}

			return dummy.next;
		}
	}
}
