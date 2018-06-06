using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeingBeing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeingBeing.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        private readonly BeingBeing.Models.BeingBeingContext _context;

        public IndexModel(BeingBeing.Models.BeingBeingContext context)
        {
            _context = context;
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
        public Social Social { get; set; }
        public Weather Weather { get; set; }
        public Working Working { get; set; }
       
        public async Task<IActionResult> OnPostAddAppetiteAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appetite.Add(Appetite);
            await _context.SaveChangesAsync();

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
