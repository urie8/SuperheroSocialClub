using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Models;
using SuperheroSocialClub.Repo;

namespace SuperheroSocialClub.Pages.SuperHeroes
{
    public class DisplaySuperHeroModel : PageModel
    {
        public SuperHero SuperHero { get; set; }
 
        public void OnGet()
        {

        }
    }
}
