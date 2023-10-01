namespace Learning_ASPNET.Models
{
	public class Generator
	{
		private readonly Random random = new Random();
		public int BringNumber()
		{
			return random.Next(100);
		}
	}
}
