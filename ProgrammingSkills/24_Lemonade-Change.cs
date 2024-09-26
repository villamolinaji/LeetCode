namespace ProgrammingSkills
{
	public class Solution24
	{
		public bool LemonadeChange(int[] bills)
		{
			bool isChangePossible = true;

			int fiveDollarCount = 0;
			int tenDollarCount = 0;
			int twentyDollarCount = 0;

			for (int i = 0; i < bills.Length; i++)
			{
				var bill = bills[i];

				if (bill == 5)
				{
					fiveDollarCount++;
				}
				else if (bill == 10)
				{
					if (fiveDollarCount > 0)
					{
						fiveDollarCount--;
						tenDollarCount++;
					}
					else
					{
						isChangePossible = false;
						break;
					}
				}
				else if (bill == 20)
				{
					if (tenDollarCount > 0 && fiveDollarCount > 0)
					{
						tenDollarCount--;
						fiveDollarCount--;
						twentyDollarCount++;
					}
					else if (fiveDollarCount >= 3)
					{
						fiveDollarCount -= 3;
						twentyDollarCount++;
					}
					else
					{
						isChangePossible = false;
						break;
					}
				}
			}

			return isChangePossible;
		}
	}
}
