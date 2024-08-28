using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_CRUD.Data;
using RazorPage_CRUD.Models;

namespace RazorPage_CRUD.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorPage_CRUD.Data.MyAppDbContext _context;

        public IndexModel(RazorPage_CRUD.Data.MyAppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
