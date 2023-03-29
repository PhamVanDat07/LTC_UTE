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
    public class IndexModel : PageModel
    {
        private readonly TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext _context;

        public IndexModel(TaoEFCoBan1_PhamVanDat_2050531200130.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
