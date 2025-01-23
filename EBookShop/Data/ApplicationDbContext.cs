using EBookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EBookShop.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }
        public DbSet<Category> Categories { get; set; }
        
             
        
    }
}
