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
        public States States { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.States.Add(States);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
