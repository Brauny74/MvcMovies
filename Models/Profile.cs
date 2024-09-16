namespace L11.Models
{
	public class Oblast
	{ 
		public string Name { get; set; }
		public int Number { get; set; }

		public Oblast(string name, int number)
		{
			Name = name;
			Number = number;
		}
	}

	public class Profile
	{
		public string Name { get; set; }
		public string FavGenre { get; set; }
		public string Gender { get; set; }
		public Oblast Oblast { get; set; }
	}
}
