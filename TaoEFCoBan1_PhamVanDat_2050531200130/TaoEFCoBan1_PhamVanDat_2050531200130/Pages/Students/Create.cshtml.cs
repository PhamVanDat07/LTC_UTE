using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaoEFCoBan1_PhamVanDat_2050531200130.Data;
using TaoEFCoBan1_PhamVanDat_2050531200130.Models;

namespace TaoEFCoBan1_PhamVanDat_2050531200130.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext _context;

        public CreateModel(TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
