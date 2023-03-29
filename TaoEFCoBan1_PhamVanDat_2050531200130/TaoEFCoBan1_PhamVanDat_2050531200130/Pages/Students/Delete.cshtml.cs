﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaoEFCoBan1_PhamVanDat_2050531200130.Data;
using TaoEFCoBan1_PhamVanDat_2050531200130.Models;

namespace TaoEFCoBan1_PhamVanDat_2050531200130.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext _context;

        public DeleteModel(TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }
            var student = await _context.Student.FindAsync(id);

            if (student != null)
            {
                Student = student;
                _context.Student.Remove(Student);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
