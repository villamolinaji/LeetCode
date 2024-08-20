namespace TopInterview150
{
	public class SOlution096
	{
		public int MinMutation(string startGene, string endGene, string[] bank)
		{
			var bankHashSet = new HashSet<string>(bank);
			if (!bankHashSet.Contains(endGene))
			{
				return -1;
			}

			var genes = new char[] { 'A', 'C', 'G', 'T' };
			var queue = new Queue<string>();
			queue.Enqueue(startGene);

			var mutations = 0;
			var visited = new HashSet<string>();
			visited.Add(startGene);

			while (queue.Count > 0)
			{
				var queueLength = queue.Count;
				for (int i = 0; i < queueLength; i++)
				{
					var current = queue.Dequeue();
					if (current == endGene)
					{
						return mutations;
					}

					var currentArray = current.ToCharArray();

					for (int j = 0; j < currentArray.Length; j++)
					{
						var originalCurrentChar = currentArray[j];
						foreach (char gene in genes)
						{
							if (gene == originalCurrentChar)
							{
								continue;
							}

							currentArray[j] = gene;
							var mutated = new string(currentArray);

							if (bankHashSet.Contains(mutated) &&
								!visited.Contains(mutated))
							{
								visited.Add(mutated);
								queue.Enqueue(mutated);
							}
						}

						currentArray[j] = originalCurrentChar;
					}
				}

				mutations++;
			}

			return -1;
		}
	}
}
