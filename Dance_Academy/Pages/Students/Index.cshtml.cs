using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dance_Academy.Data;
using Dance_Academy.Models;

namespace Dance_Academy.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Dance_Academy.Data.SchoolContext _context;

        public IndexModel(Dance_Academy.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
