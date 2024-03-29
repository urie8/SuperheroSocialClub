using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Models;
using SuperheroSocialClub.Repo;

namespace SuperheroSocialClub.Pages.SuperHeroes
{
    public class UpdateSuperHeroModel : PageModel
    {
        [BindProperty]
        public SuperHero SuperHero { get; set; }

        public void OnGet(int id)
        {
            SuperHero = SuperHeroManager.SuperHeroes.FirstOrDefault(s => s.Id == id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }


            SuperHeroManager.UpdateSuperHero(SuperHero);
            return RedirectToPage("/Index", new { SuperHero.Name, SuperHero.SecretIdentity });

        }
    }
}
