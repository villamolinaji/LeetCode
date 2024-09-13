namespace GoogleSpring
{
	public class Solution02
	{
		public IList<string> FindItinerary(IList<IList<string>> tickets)
		{
			var graph = new Dictionary<string, PriorityQueue<string, string>>();

			foreach (var ticket in tickets)
			{
				string from = ticket[0];
				string to = ticket[1];

				if (!graph.ContainsKey(from))
				{
					graph[from] = new PriorityQueue<string, string>();
				}

				graph[from].Enqueue(to, to);
			}

			var itinerary = new List<string>();

			DFS("JFK", graph, itinerary);

			itinerary.Reverse();

			return itinerary;
		}

		private void DFS(string airport, Dictionary<string, PriorityQueue<string, string>> graph, List<string> itinerary)
		{
			while (graph.ContainsKey(airport) &&
				graph[airport].Count > 0)
			{
				var nextAirport = graph[airport].Dequeue();
				if (nextAirport != null)
				{
					DFS(nextAirport, graph, itinerary);
				}
			}

			itinerary.Add(airport);
		}
	}
}
