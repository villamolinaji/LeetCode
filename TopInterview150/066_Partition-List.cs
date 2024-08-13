namespace TopInterview150
{
	public class Solution066
	{
		public ListNode? Partition(ListNode? head, int x)
		{
			if (head == null)
			{
				return null;
			}

			var lessHead = new ListNode(0);
			var greaterHead = new ListNode(0);

			var lessNode = lessHead;
			var greaterNode = greaterHead;

			while (head != null)
			{
				if (head.val < x)
				{
					lessNode.next = head;
					lessNode = lessNode.next;
				}
				else
				{
					greaterNode.next = head;
					greaterNode = greaterNode.next;
				}

				head = head.next;
			}

			greaterNode.next = null;

			lessNode.next = greaterHead.next;

			return lessHead.next;
		}
	}
}
