namespace LeetCode75
{
	public class Solution43
	{
		public bool CanVisitAllRooms(IList<IList<int>> rooms)
		{
			var keys = new List<int>();
			var visited = new List<int>();

			keys.AddRange(rooms[0]);
			visited.Add(0);

			while (keys.Any())
			{
				var key = keys[0];
				if (!visited.Contains(key))
				{
					visited.Add(key);
				}
				keys.RemoveAt(0);

				var newRooms = rooms[key].Where(r => !visited.Contains(r));
				keys.AddRange(newRooms);
			}

			if (visited.Count == rooms.Count)
			{
				return true;
			}

			return false;
		}
	}
}
