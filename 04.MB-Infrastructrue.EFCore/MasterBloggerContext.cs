using _01.MB.Domin.ArticleAgg;
using _01.MB.Domin.ArticleCategoryAgg;
using _04.MB_Infrastructrue.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace _04.MB_Infrastructrue.EFCore
{
    public class MasterBloggerContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public MasterBloggerContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
