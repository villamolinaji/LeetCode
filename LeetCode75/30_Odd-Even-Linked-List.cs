namespace LeetCode75
{
	public class Solution30
	{
		public ListNode? OddEvenList(ListNode head)
		{
			if (head == null)
			{
				return null;
			}

			var odd = new Queue<int>();
			var even = new Queue<int>();

			var current = head;
			int index = 0;
			odd.Enqueue(current.val);

			while (current.next != null)
			{
				current = current.next;

				if (index % 2 != 0)
				{
					odd.Enqueue(current.val);
				}
				else
				{
					even.Enqueue(current.val);
				}

				index++;
			}			

			var currentValue = odd.Dequeue();
			var returnLisNode = new ListNode(currentValue);
			current = returnLisNode;

			while (odd.Count > 0)
			{
				current.next = new ListNode(odd.Dequeue());
				current = current.next;
			}
			while (even.Count > 0)
			{
				current.next = new ListNode(even.Dequeue());
				current = current.next;
			}

			return returnLisNode;
		}
	}
}
