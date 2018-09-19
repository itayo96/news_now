using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;

namespace NewsNow.Models
{
    public class NewsNowContext : DbContext
    {
        public NewsNowContext (DbContextOptions<NewsNowContext> options)
            : base(options)
        {
        }

        public DbSet<NewsNow.Models.ExampleStatisticsModel> ExampleStatistics { get; set; }

        public DbSet<NewsNow.Models.Article> Articles { get; set; }

        public DbSet<NewsNow.Models.Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
            .HasOne(p => p.Category)
            .WithMany(b => b.Articles)
            .OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<CategoryModel>().HasMany<ArticleModel>(c => c.Articles).WithOne(art => art.Category);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "News" });
            modelBuilder.Entity<Article>().HasData(
                new { CategoryId = 1, ArticleId = 1, HomeHeader = "Targets in Syria: Bombs", HomeContent = "This is the description of an article. Read more.", HomeImage= "https://i.ytimg.com/vi/R_iYQlMw0r0/maxresdefault.jpg", DateCreated = DateTime.Now },
                new { CategoryId = 1, ArticleId = 2, HomeHeader = "\"West side is a prison\"", HomeContent = "This is the description of an article. Read more.", HomeImage = "http://www.bworldonline.com/wp-content/uploads/2018/02/Megaworld-Westside-City.jpg", DateCreated = DateTime.Now },
                new { CategoryId = 1, ArticleId = 3, HomeHeader = "The Israeli startups in space", HomeContent = "This is the description of an article. Read more.", HomeImage = "https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2017/whatisspacet.jpg", DateCreated = DateTime.Now });

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Sports" });
            modelBuilder.Entity<Article>().HasData(
                new { CategoryId = 2, ArticleId = 4, HomeHeader = "1:0 on Raanana vs Kaka", HomeContent = "This is the description of an article. Read more.", HomeImage = "https://sportshub.cbsistatic.com/i/r/2018/07/15/31f520b7-cad4-48f7-8509-485d51cfb90a/thumbnail/370x208/26c493f4ffe1ad85aea04580c4eb45bb/lionel-messi-argentina.jpg", DateCreated = DateTime.Now },
                new { CategoryId = 2, ArticleId = 5, HomeHeader = "Dummy article", HomeContent = "This is the description of an article. Read more.", DateCreated = DateTime.Now },
                new { CategoryId = 2, ArticleId = 6, HomeHeader = "Dummy article", HomeContent = "This is the description of an article. Read more.", DateCreated = DateTime.Now });

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Politics" });
            modelBuilder.Entity<Article>().HasData(
                new { CategoryId = 3, ArticleId = 7, HomeHeader = "Dummy article", HomeContent = "This is the description of an article. Read more.", DateCreated = DateTime.Now },
                new { CategoryId = 3, ArticleId = 8, HomeHeader = "Dummy article", HomeContent = "This is the description of an article. Read more.", DateCreated = DateTime.Now },
                new { CategoryId = 3, ArticleId = 9, HomeHeader = "Dummy article", HomeContent = "This is the description of an article. Read more.", DateCreated = DateTime.Now });
        }
    }
}
