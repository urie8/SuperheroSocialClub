using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Models;
using SuperheroSocialClub.Repo;

namespace SuperheroSocialClub.Pages.SuperHeroes
{
	public class AddSuperHeroModel : PageModel
	{
		[BindProperty]
		public SuperHero SuperHero { get; set; }
		public void OnGet()
		{

		}

		public IActionResult OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return Page();
			}

			SuperHeroManager.AddSuperHero(SuperHero);
			return RedirectToPage("/Index");

		}
	}
}
