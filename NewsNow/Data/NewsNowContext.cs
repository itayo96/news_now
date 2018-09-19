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

        public DbSet<NewsNow.Models.ArticleModel> Article { get; set; }
    }
}
