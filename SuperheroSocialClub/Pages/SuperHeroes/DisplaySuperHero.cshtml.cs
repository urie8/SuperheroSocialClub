using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Repo;

namespace SuperheroSocialClub.Pages.SuperHeroes
{
    public class DisplaySuperHeroModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPostDelete(int id)
        {
            SuperHeroManager.DeleteSuperHero(id);
        }
    }
}
