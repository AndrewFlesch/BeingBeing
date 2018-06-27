using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeingBeing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BeingBeing.Data;
using BeingBeing.Authorization;

namespace BeingBeing.Pages
{
    public class IndexModel : DI_BasePageModel
    {
        public void OnGet()
        {

        }

        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context,
        IAuthorizationService authorizationService,
        UserManager<AppUser> userManager)
        : base(context, authorizationService, userManager)
        {
        }

        [BindProperty]
        public Appetite Appetite { get; set; }
        public Consuming Consuming { get; set; }
        public EmotionalStates EmotionalStates { get; set; }
        public Exercise Exercise { get; set; }
        public Pills Pills { get; set; }
        public Poop Poop { get; set; }
        public Sickness Sickness { get; set; }
        public Sleep Sleep { get; set; }
        public Stats Stats { get; set; }
        public Social Social { get; set; }
        public Weather Weather { get; set; }
        public Working Working { get; set; }


        [Authorize]
        public async Task<IActionResult> OnPostAddAppetiteAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Appetite.OwnerID = UserManager.GetUserId(User);

            // requires using ContactManager.Authorization;
            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                            User, Appetite,
                                            Operations.Create);

            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            Context.Appetite.Add(Appetite);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        public async Task<IActionResult> OnPostAddDoingAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.EmotionalStates.Add(EmotionalStates);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
