using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Pages.items
{
    public class DetailsModel : PageModel
    {
        private readonly itemContext _context;

        public DetailsModel(itemContext context)
        {
            _context = context;
        }

        public item item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            item = await _context.item.FirstOrDefaultAsync(m => m.ID == id);

            if (item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
