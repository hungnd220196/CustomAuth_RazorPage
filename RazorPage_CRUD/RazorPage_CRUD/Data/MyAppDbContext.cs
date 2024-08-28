using Microsoft.EntityFrameworkCore;
using RazorPage_CRUD.Models;

namespace RazorPage_CRUD.Data
{
    public class MyAppDbContext:DbContext
    {
        public MyAppDbContext(DbContextOptions options): base(options) 
        {
            

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
