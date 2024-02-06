using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Repo
{
	public static class SuperHeroManager
	{
		public static List<SuperHero> SuperHeroes { get; set; } = new()
		{

		};

		static void AddSuperHero(int id, string name, string secretIdentity, string superPower)
		{
			SuperHero newSuperHero = new()
			{
				Id = id,
				Name = name,
				SecretIdentity = secretIdentity,
				SuperPower = superPower
			};

			SuperHeroes.Add(newSuperHero);
		}

		static void UpdateSuperHero(int id)
		{
			SuperHero SupeHeroToUpdate = SuperHeroes.FirstOrDefault(s => s.Id == id);

		}

		static void DeleteSuperHero(int id)
		{
			SuperHero SuperHeroToDelete = SuperHeroes.FirstOrDefault(s => s.Id == id);
			SuperHeroes.Remove(SuperHeroToDelete);
		}
	}
}
