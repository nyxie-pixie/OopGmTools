namespace GMsAssistant
{
	public class Character
	{
		public string Name { get; set; }
		public int HPMax { get; set; }
		public int HPCurrent { get; set; }
		public int Initiative { get; set; }
		public int CharID { get; set; }
	}
	public class Dice()
	{
		public int Faces { get; set; }
		public int NumberOfDice { get; set; }
		public int Roll(int NumberOfDice, int Faces)
		{
			int total = 0;
			Random die = new Random();
			while (NumberOfDice > 0)
			{
				
				
				int rolledDie = die.Next(1, (Faces + 1));
				total += rolledDie;
				NumberOfDice--;
				
			}
			return total;
		}
	}
}
