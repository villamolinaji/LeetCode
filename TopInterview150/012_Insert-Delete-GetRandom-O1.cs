namespace TopInterview150
{
	public class RandomizedSet
	{
		public HashSet<int> MyList { get; set; }

		public RandomizedSet()
		{
			MyList = new HashSet<int>();
		}

		public bool Insert(int val)
		{
			if (!MyList.Contains(val))
			{
				MyList.Add(val);

				return true;
			}

			return false;

		}

		public bool Remove(int val)
		{
			if (MyList.Contains(val))
			{
				MyList.Remove(val);

				return true;
			}

			return false;
		}

		public int GetRandom()
		{
			Random rand = new Random();
			int index = rand.Next(MyList.Count);

			return MyList.ElementAt(index);

		}
	}

}
