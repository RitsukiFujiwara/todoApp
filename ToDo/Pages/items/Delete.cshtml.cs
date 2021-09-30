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
    public class DeleteModel : PageModel
    {
        private readonly itemContext _context;

        public DeleteModel(itemContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            item = await _context.item.FindAsync(id);

            if (item != null)
            {
                _context.item.Remove(item);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
