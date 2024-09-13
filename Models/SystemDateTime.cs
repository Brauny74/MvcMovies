namespace L11.Models
{
	public interface IDateTime
	{ 
		DateTime Now { get; }
	}

	public class SystemDateTime : IDateTime
	{
		public DateTime Now => DateTime.Now;
	}
}
