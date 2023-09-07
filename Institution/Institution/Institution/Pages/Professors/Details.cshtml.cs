﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Institution.Data;
using Institution.Model;

namespace Institution.Pages.Professors
{
    public class DetailsModel : PageModel
    {
        private readonly Institution.Data.ApplicationDBContext _context;

        public DetailsModel(Institution.Data.ApplicationDBContext context)
        {
            _context = context;
        }

      public Professor Professor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Professors == null)
            {
                return NotFound();
            }

            var professor = await _context.Professors.FirstOrDefaultAsync(m => m.IdStudent == id);
            if (professor == null)
            {
                return NotFound();
            }
            else 
            {
                Professor = professor;
            }
            return Page();
        }
    }
}
