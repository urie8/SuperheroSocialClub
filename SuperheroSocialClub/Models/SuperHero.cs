namespace SuperheroSocialClub.Models
{
	public class SuperHero
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? SecretIdentity { get; set; }
		public string SuperPower { get; set; } = null!;
		public string? Image { get; set; }
	}
}
