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
    public class IndexModel : PageModel
    {
        private readonly itemContext _context;

        public IndexModel(itemContext context)
        {
            _context = context;
        }

        public IList<item> item { get;set; }

        public async Task OnGetAsync()
        {
            item = await _context.item.ToListAsync();
        }
    }
}
