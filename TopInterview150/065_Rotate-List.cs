namespace TopInterview150
{
	public class Solution065
	{
		public ListNode? RotateRight(ListNode head, int k)
		{
			if (head == null ||
				head.next == null ||
				k == 0)
			{
				return head;
			}

			var current = head;
			var length = 1;
			while (current.next != null)
			{
				current = current.next;
				length++;
			}

			current.next = head;

			k = k % length;
			var stepsToNewHead = length - k;

			current = head;
			for (int i = 0; i < stepsToNewHead - 1; i++)
			{
				current = current?.next;
			}

			var newHead = current?.next;
			if (current != null)
			{
				current.next = null;
			}

			return newHead;
		}
	}
}
