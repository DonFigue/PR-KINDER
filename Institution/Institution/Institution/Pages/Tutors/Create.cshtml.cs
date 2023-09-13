using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Tutors
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
        public Tutor Tutor { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Tutors == null || Tutor == null)
            {
                return Page();
            }

            _context.Tutors.Add(Tutor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
