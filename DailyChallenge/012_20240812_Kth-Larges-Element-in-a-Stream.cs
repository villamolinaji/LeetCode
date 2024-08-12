namespace DailyChallenge
{
	public class KthLargest
	{
		public List<int> MyList { get; set; }
		public int K { get; set; }

		public KthLargest(int k, int[] nums)
		{
			K = k;
			MyList = new List<int>(nums);
			MyList.Sort();
		}

		public int Add(int val)
		{
			MyList.Add(val);
			MyList.Sort();

			return MyList[MyList.Count - K];
		}
	}
}
