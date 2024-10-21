namespace BinarySearch
{
	public class SnapshotArray
	{
		private List<(int snapId, int value)>[] Arr { get; set; }
		private int SnapId { get; set; }

		public SnapshotArray(int length)
		{
			Arr = new List<(int snapId, int value)>[length];
			for (int i = 0; i < length; i++)
			{
				Arr[i] = new List<(int snapId, int value)> { (0, 0) };
			}

			SnapId = 0;
		}

		public void Set(int index, int val)
		{
			var changes = Arr[index];
			if (changes.Count > 0 &&
				changes[changes.Count - 1].snapId == SnapId)
			{
				changes[changes.Count - 1] = (SnapId, val);
			}
			else
			{
				changes.Add((SnapId, val));
			}
		}

		public int Snap()
		{
			return SnapId++;
		}

		public int Get(int index, int snapId)
		{
			var changes = Arr[index];

			int left = 0;
			int right = changes.Count - 1;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (changes[mid].snapId <= snapId)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return changes[right].value;
		}
	}
}
