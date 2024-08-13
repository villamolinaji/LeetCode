namespace TopInterview150
{
	public class Solution064
	{
		public ListNode? DeleteDuplicates(ListNode? head)
		{
			if (head == null)
			{
				return null;
			}

			var result = new ListNode(0);
			result.next = head;
			var prev = result;

			while (head != null)
			{
				if (head.next != null &&
					head.val == head.next.val)
				{
					while (head.next != null &&
						head.val == head.next.val)
					{
						head = head.next;
					}

					if (prev != null)
					{
						prev.next = head.next;
					}
				}
				else
				{
					prev = prev?.next;
				}

				head = head.next;
			}

			return result.next;
		}
	}
}
