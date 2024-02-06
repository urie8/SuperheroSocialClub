using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Repo
{
    public static class SuperHeroManager
    {
        public static List<SuperHero> SuperHeroes { get; set; } = new()
        {
            new SuperHero()
            {
                Id = 1,
                Name = "Superman",
                SecretIdentity = "Clark Kent",
                SuperPower = "Super strength"
            },

            new SuperHero()
            {
                Id = 2,
                Name = "Batman",
                SecretIdentity = "Bruce Wayne",
                SuperPower = "Smart"
            }
        };

        public static void AddSuperHero(SuperHero newSuperHero)
        {
            SuperHeroes.Add(newSuperHero);
        }

        public static void UpdateSuperHero(SuperHero superHeroToUpdate)
        {
            SuperHeroes.Remove(SuperHeroes.FirstOrDefault(s => s.Id == superHeroToUpdate.Id));
            SuperHeroes.Add(superHeroToUpdate);

        }

        public static void DeleteSuperHero(int id)
        {
            SuperHero SuperHeroToDelete = SuperHeroes.FirstOrDefault(s => s.Id == id);
            SuperHeroes.Remove(SuperHeroToDelete);
        }
    }
}
