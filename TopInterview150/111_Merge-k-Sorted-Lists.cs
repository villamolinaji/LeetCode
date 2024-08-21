namespace TopInterview150
{
	public class SOlution111
	{
		public ListNode? MergeKLists(ListNode[] lists)
		{
			var values = new List<int>();

			foreach (var list in lists)
			{
				var listNode = list;
				while (listNode != null)
				{
					values.Add(listNode.val);
					listNode = listNode.next;
				}
			}

			values.Sort();

			var result = new ListNode(0);
			var current = result;

			foreach (var value in values)
			{
				current.next = new ListNode(value);
				current = current.next;
			}


			return result.next;
		}
	}
}
