using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Models;
using SuperheroSocialClub.Repo;
using System.ComponentModel.DataAnnotations;


namespace SuperheroSocialClub.Pages.SuperheroPages
{

    [BindProperties]
    public class RegisterSuperheroModel : PageModel
    {
        public List<SuperHero> Superheroes {  get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SecretIdentity { get; set; } = null!;
        public string? Superpower { get; set; }
        public string? Image { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (Name != null && SecretIdentity != null && Superpower != null)
            {
  
                string name = Name;
                string secretIdentity = SecretIdentity;
                string superpower = Superpower;

                SuperHeroManager.AddSuperHero(Id ,name, secretIdentity, superpower);

                return RedirectToPage("/´SuperheroPages/Details", new { Name, SecretIdentity, Superpower});
            }
            else
            {
                return Page();
            }
        }



    }
}
