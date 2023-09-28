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

namespace Institution.Pages.Tutors
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
        public Tutor Tutor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tutors == null)
            {
                return NotFound();
            }

            var tutor =  await _context.Tutors.FirstOrDefaultAsync(m => m.IdTutor == id);
            if (tutor == null)
            {
                return NotFound();
            }
            Tutor = tutor;
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

            _context.Attach(Tutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorExists(Tutor.IdTutor))
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

        private bool TutorExists(int id)
        {
          return (_context.Tutors?.Any(e => e.IdTutor == id)).GetValueOrDefault();
        }
        */
    }
}
