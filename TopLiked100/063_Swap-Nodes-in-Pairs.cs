namespace TopLiked100
{
	public class Solution063
	{
		public ListNode SwapPairs(ListNode head)
		{
			var dummy = new ListNode(0);
			dummy.next = head;

			var prevNode = dummy;

			while (prevNode.next != null &&
				prevNode.next.next != null)
			{
				var firstNode = prevNode.next;
				var secondNode = prevNode.next.next;

				firstNode.next = secondNode.next;
				secondNode.next = firstNode;
				prevNode.next = secondNode;

				prevNode = firstNode;
			}

			return dummy.next;
		}
	}
}
