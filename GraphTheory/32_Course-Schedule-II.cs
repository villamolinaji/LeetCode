namespace GraphTheory
{
	public class Solution32
	{
		public int[] FindOrder(int numCourses, int[][] prerequisites)
		{
			var graph = new List<int>[numCourses];
			int[] inDegree = new int[numCourses];

			for (int i = 0; i < numCourses; i++)
			{
				graph[i] = new List<int>();
			}

			foreach (var prerequisite in prerequisites)
			{
				int course = prerequisite[0];
				int pre = prerequisite[1];
				graph[pre].Add(course);
				inDegree[course]++;
			}

			var queue = new Queue<int>();
			for (int i = 0; i < numCourses; i++)
			{
				if (inDegree[i] == 0)
				{
					queue.Enqueue(i);
				}
			}

			var order = new List<int>();
			while (queue.Count > 0)
			{
				var currentCourse = queue.Dequeue();
				order.Add(currentCourse);

				foreach (var neighbor in graph[currentCourse])
				{
					inDegree[neighbor]--;
					if (inDegree[neighbor] == 0)
					{
						queue.Enqueue(neighbor);
					}
				}
			}

			if (order.Count == numCourses)
			{
				return order.ToArray();
			}
			else
			{
				return new int[0];
			}
		}
	}
}
