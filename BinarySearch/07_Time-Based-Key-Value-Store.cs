namespace BinarySearch
{
	public class TimeMap
	{
		private Dictionary<string, List<(int timestamp, string value)>> Map { get; set; }

		public TimeMap()
		{
			Map = new Dictionary<string, List<(int timestamp, string value)>>();
		}

		public void Set(string key, string value, int timestamp)
		{
			if (!Map.ContainsKey(key))
			{
				Map[key] = new List<(int timestamp, string value)>();
			}

			Map[key].Add((timestamp, value));
		}

		public string Get(string key, int timestamp)
		{
			if (!Map.ContainsKey(key))
			{
				return "";
			}

			var values = Map[key];

			int left = 0;
			int right = values.Count - 1;
			string result = "";

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (values[mid].timestamp <= timestamp)
				{
					result = values[mid].value;
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}

			return result;
		}
	}
}
