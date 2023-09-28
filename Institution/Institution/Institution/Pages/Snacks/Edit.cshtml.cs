using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Snacks
{
    public class EditModel : PageModel
    {
        /*
        private readonly Institution.Data.ApplicationDBContext _context;

        public EditModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Snack Snack { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Snack == null)
            {
                return NotFound();
            }

            var snack =  await _context.Snack.FirstOrDefaultAsync(m => m.IdSnack == id);
            if (snack == null)
            {
                return NotFound();
            }
            Snack = snack;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Snack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SnackExists(Snack.IdSnack))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SnackExists(int id)
        {
          return (_context.Snack?.Any(e => e.IdSnack == id)).GetValueOrDefault();
        }
        */
    }
}
