using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Snacks
{
    public class CreateModel : PageModel
    {
        private readonly Institution.Data.ApplicationDBContext _context;

        public CreateModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Snack Snack { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Snack == null || Snack == null)
            {
                return Page();
            }

            _context.Snack.Add(Snack);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
