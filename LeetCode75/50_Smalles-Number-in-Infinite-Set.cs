namespace LeetCode75
{
	public class SmallestInfiniteSet
	{
		public int CurrentSmallest { get; set; }
		public SortedSet<int> Removed { get; set; }

		public SmallestInfiniteSet()
		{
			CurrentSmallest = 1;
			Removed = new SortedSet<int>();
		}

		public int PopSmallest()
		{
			if (Removed.Count > 0)
			{
				int smallest = Removed.Min;
				Removed.Remove(smallest);

				return smallest;
			}

			return CurrentSmallest++;
		}

		public void AddBack(int num)
		{
			if (num < CurrentSmallest && !Removed.Contains(num))
			{
				Removed.Add(num);
			}
		}
	}
}
