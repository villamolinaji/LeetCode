namespace TopLiked100
{
	public class Solution070
	{
		public ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
		{

#pragma warning disable S125 // Sections of code should not be commented out
			//var listNodesA = new List<ListNode>();

			//var currenNodeA = headA;
			//while (currenNodeA != null)
			//{
			//	listNodesA.Add(currenNodeA);
			//	currenNodeA = currenNodeA.next;
			//}

			//var currenNodeB = headB;
			//while (currenNodeB != null)
			//{
			//	if (listNodesA.Contains(currenNodeB))
			//	{
			//		return currenNodeB;
			//	}

			//	currenNodeB = currenNodeB.next;
			//}

			//return null;
#pragma warning restore S125 // Sections of code should not be commented out

			var currenNodeA = headA;
			var currenNodeB = headB;

			while (currenNodeA != currenNodeB)
			{
				currenNodeA = currenNodeA == null
					? headB
					: currenNodeA.next;

				currenNodeB = currenNodeB == null
					? headA
					: currenNodeB.next;
			}

			return currenNodeA;
		}
	}
}
