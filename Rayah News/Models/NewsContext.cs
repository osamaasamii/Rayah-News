using Microsoft.EntityFrameworkCore;

namespace Rayah_News.Models
{
    // المسئول عن مابينج الداتا الي معمولها كلاس عندي للداتا بيز
    public class NewsContext :DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options):base(options)
        {

        }
            
        public DbSet<News> News { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUS> ContactUs { get; set; } 
        public DbSet<Teammember> Teammembers { get; set; }

    }
   
}
