namespace LeetCode75
{
	public class ListNode
	{		
		public int val { get; set; }
		public ListNode? next { get; set; }
		public ListNode(int val = 0, ListNode? next = null)
		{
			this.val = val;
			this.next = next;
		}
	 }

	public class Solution29
	{
		public ListNode? DeleteMiddle(ListNode head)
		{
			int countNodes = 0;

			var current = head;

			while (current.next != null)
			{
				countNodes++;
				current = current.next;
			}
			countNodes++;

			int middle = countNodes / 2;
			int index = 0;

			current = head;
			var prev = current;
			while (index < middle)
			{
				prev = current;
				current = current?.next;
				index++;
			}

			if (prev is not null)
			{
				prev.next = current?.next;
			}

			if (middle == 0)
			{
				return null;
			}

			return head;
		}
	}
}
