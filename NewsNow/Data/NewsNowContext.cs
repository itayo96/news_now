﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;

namespace NewsNow.Models
{
    public class NewsNowContext : IdentityDbContext<ApplicationUser>
    {
        public NewsNowContext(DbContextOptions<NewsNowContext> options)
            : base(options)
        {
        }

        public DbSet<NewsNow.Models.ExampleStatisticsModel> ExampleStatistics { get; set; }

        public DbSet<NewsNow.Models.Article> Articles { get; set; }

        public DbSet<NewsNow.Models.Category> Categories { get; set; }

        public DbSet<NewsNow.Models.Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Article>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Articles)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comment>()
                .HasOne(p => p.Article)
                .WithMany(b => b.Comments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                Name = "World",
                Description = "World wide news",
                Color = System.Drawing.Color.MidnightBlue
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                Name = "Politics",
                Description = "Debates and conflicts",
                Color = System.Drawing.Color.DarkMagenta
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                Name = "Business",
                Description = "Trade, commerce and money",
                Color = System.Drawing.Color.DarkGreen
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 4,
                Name = "Sports",
                Description = "And its a score!",
                Color = System.Drawing.Color.DarkRed
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 5,
                Name = "Culture",
                Description = "Music, movies and the starts",
                Color = System.Drawing.Color.Crimson
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 6,
                Name = "Opinions",
                Description = "I Think...",
                Color = System.Drawing.Color.SeaGreen
            });

            modelBuilder.Entity<Article>().HasData(
                new Article()
                {
                    ArticleId = 1,
                    CategoryId = 1,
                    Header = "Iran blames US and Saudi Arabia for terror attack",
                    Summery = "Iran blames the US and Saudi Arabia for military parade terror attack",
                    DateCreated = new DateTime(2018, 5, 1, 8, 30, 52),
                    HomeImageUrl =
                        "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/427101",
                    Location = "טהרן, אירן",
                    IsShowMap = true,
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 2,
                    CategoryId = 2,
                    Header = "Gilad Erdan: Israel making progress against Terror",
                    Summery =
                        "Erdan is responsible for the fight against BDS in the Strategic Affairs Ministry, and the steps he has taken in that battle are controversial and unconventional.",
                    DateCreated = new DateTime(2018, 8, 7, 5, 22, 23),
                    HomeImageUrl =
                        "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_TopStoryMainImageFaceDetect/429944",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 3,
                    CategoryId = 1,
                    Header = "Russia: We were mislead by israel",
                    Summery =
                        "Maj. Gen. Igor Konashenkov, chief spokesman for the Russian Ministry of Defense, said that Israeli strikes in Syria put Russian forces there at risk.",
                    DateCreated = new DateTime(2018, 3, 7, 2, 22, 23),
                    HomeImageUrl =
                        "https://images.haarets.co.il/image/upload/w_2184,h_1270,x_0,y_75,c_crop,g_north_west/w_857,h_482,q_auto,c_fill,f_auto/fl_any_format.preserve_transparency.progressive:none/v1537691679/1.6494059.1232180831.jpg",
                    Location = "תל אביב, ישראל",
                    IsShowMap = true,
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 4,
                    CategoryId = 1,
                    Header = "Israel rejects russian claims: IAF did not hide behind russian plane",
                    Summery =
                        "The IAF did not hide behind any plane and Israeli fighter jets were in Israeli airspace when the Syrians attacked the Russian plane",
                    DateCreated = new DateTime(2018, 10, 6, 11, 10, 2),
                    HomeImageUrl = "https://www.jpost.com/HttpHandlers/ShowImage.ashx?id=350908&w=898&h=628",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 5,
                    CategoryId = 1,
                    Header = "U.S. Terror victomsm ask Trump: bar Abbas",
                    Summery =
                        "The family members called the decision to allow Abbas’s entry to the US \"a slap in the face to every American who has suffered from terror.\"",
                    DateCreated = new DateTime(2017, 12, 11, 11, 10, 2),
                    HomeImageUrl =
                        "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/428957",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 6,
                    CategoryId = 5,
                    Header = "Trails and Tribulations of Eurovision 2019, What to expect next?",
                    Summery =
                        "For the next eight months, squabbles over politics, money and religion are bound to plague the upcoming Eurovision. But which arguments should be taken seriously?",
                    DateCreated = new DateTime(2017, 3, 8, 11, 10, 2),
                    HomeImageUrl =
                        "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429094",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 7,
                    CategoryId = 5,
                    Header = "Livinng out the Baha'i: A journy to Israel",
                    Summery =
                        "More than a million people visit the gardens every year. Apart from being at the holiest site of his faith...",
                    DateCreated = new DateTime(2018, 10, 30, 11, 10, 2),
                    HomeImageUrl =
                        "https://images.jpost.com/image/upload/f_auto,fl_lossy/t_Article2016_ControlFaceDetect/429990",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 8,
                    CategoryId = 5,
                    Header = "Highlights: Texas snaps 4-game skid to No. 17 TCU",
                    Summery =
                        "Finland has produced more Formula One champions per capita than any other country in the world",
                    DateCreated = new DateTime(2018, 9, 6, 11, 10, 2),
                    HomeImageUrl =
                        "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 9,
                    CategoryId = 6,
                    Header = "Russia is still attacking the US and trying to help Trump",
                    Summery =
                        "Microsoft's revelation of yet another Russian operation assaulting democratic institutions -- including conservative think tanks that disagree with President Trump -- proves that Vladimir Putin is still trying to help Trump, writes Frida Ghitis.",
                    DateCreated = new DateTime(2018, 9, 7, 11, 10, 2),
                    HomeImageUrl =
                        "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAAuljC.img?h=170&w=300&m=6&q=60&u=t&o=t&l=f&f=jpg&x=585&y=345",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 10,
                    CategoryId = 3,
                    Header = "Comcast outbids 21st Century Fox for Sky",
                    Summery =
                        "American cable giant Comcast lodged a winning bid of about $40 billion (£30.6 billion) for Sky following a rare, three round auction managed by UK's Takeover Panel",
                    DateCreated = new DateTime(2018, 8, 6, 11, 10, 2),
                    HomeImageUrl = "https://i.cdn.turner.com/money/dam/assets/180920115724-comcast-fox-sky-780x439.jpg",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                },
                new Article()
                {
                    ArticleId = 11,
                    CategoryId = 3,
                    Header = "BMW vision's for a self-driving electric car",
                    Summery =
                        "BMW has unveiled its vision for a self-driving electric crossover SUV and, if it actually ends up being a lot like the concept.",
                    DateCreated = new DateTime(2018, 8, 6, 10, 10, 2),
                    HomeImageUrl = "https://i.cdn.turner.com/money/dam/assets/180913172656-bmw-inext-780x439.jpg",
                    Location = "תל אביב, ישראל",
                    Content = exampleContent
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    CommentId = 1,
                    DatePosted = new DateTime(2018, 8, 2, 8, 10, 0),
                    ArticleId = 1,
                    Author = "The one who knows",
                    Content = "Example content for an example comment",
                    Sequence = 1
                },
                new Comment()
                {
                    CommentId = 2,
                    DatePosted = new DateTime(2018, 8, 16, 9, 10, 0),
                    ArticleId = 1,
                    Author = "Voldemort",
                    Content = "Multi line comment! I think this is an example comment",
                    Sequence = 2
                },
                new Comment()
                {
                    CommentId = 3,
                    DatePosted = new DateTime(2018, 9, 2, 8, 0, 15),
                    ArticleId = 1,
                    Author = "Jimmi",
                    Content = "Example content for an example comment",
                    Sequence = 3
                }
            );
        }

        static string exampleContent =
            "This is an example article with multiple paragraphs, **bolds**, *\"quotes\"* and others.\r\n\r\n\r\nexample paragraph\r\n--\r\n\r\nThe statement from attorneys Debra Katz, Lisa Banks and Michael Bromwich came after a call Sunday with staff for the Senate Judiciary Committee. Kavanaugh has denied the allegations and said he wants to testify before the committee.\r\n\r\n*\"Despite actual threats to her safety and her life, Dr. Ford believes it is important for Senators to hear directly from her about the sexual assault committed against her,\"* the statement read.\r\n\r\nparagraph with image\r\n--\r\n*\"We stand with the Iranian people against the scourge of radical Islamic terrorism and express our sympathy to them at this terrible time,\"* she said Saturday.\r\n\r\nThe parade was part of nationwide celebrations in Iran to mark the 30th anniversary of the end of its eight-year war with Iraq.\r\nGunmen opened fire on armed forces marching inside a park as well as spectators who had gathered to watch the parade, Iranian armed forces spokesman Brig. Gen. Abolfazl Shekarchi told Mehr, a semi-official Iranian news agency.\r\nAll four attackers were killed during clashes with security forces, IRNA reported, citing the deputy governor-general of Khuzestan province, where the attack happened.\r\n\r\n![](https://cdn.cnn.com/cnnnext/dam/assets/180922044651-iran-parade-attack-09-22-18-exlarge-169.jpg)\r\n*Injured soldiers lie on the ground after Saturday's attack on a military parade Ahvaz, Iran.*\r\n\r\n*\"The terrorists disguised as Islamic Revolution Guards Corps and Basij (volunteer) forces opened fire to the authority and people from behind the stand during the parade,\"* said Gholam-Reza Shariati, governor of Khuzestan province, according to IRNA.\r\nKhuzestan is a province that borders Iraq and has a large ethnic Arab community, many of them Sunni. It was a major battleground during the Iran-Iraq War that killed half a million soldiers in the '80s.\r\n";
    }
}