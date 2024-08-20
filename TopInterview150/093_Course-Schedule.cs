namespace LeetCode75
{
	public class Solution093
	{
		public bool CanFinish(int numCourses, int[][] prerequisites)
		{
			var graph = new List<int>[numCourses];
			int[] inDegree = new int[numCourses];

			for (int i = 0; i < numCourses; i++)
			{
				graph[i] = new List<int>();
			}

			foreach (var prerequisite in prerequisites)
			{
				var course = prerequisite[0];
				var pre = prerequisite[1];
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

			int processedCourses = 0;
			while (queue.Count > 0)
			{
				var currentCourse = queue.Dequeue();
				processedCourses++;

				foreach (var neighbor in graph[currentCourse])
				{
					inDegree[neighbor]--;
					if (inDegree[neighbor] == 0)
					{
						queue.Enqueue(neighbor);
					}
				}
			}

			return processedCourses == numCourses;
		}
	}
}
