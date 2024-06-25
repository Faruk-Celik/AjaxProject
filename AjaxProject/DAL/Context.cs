using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context : DbContext

    {
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VB768D\\SQLEXPRESS02; initial catalog=AjaxDb; integrated Security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
        
}
