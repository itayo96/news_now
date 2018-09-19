﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsNow.Models;

namespace NewsNow.Migrations
{
    [DbContext(typeof(NewsNowContext))]
    [Migration("20180919170338_Initiat-Data7")]
    partial class InitiatData7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsNow.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("DetailedContent");

                    b.Property<string>("DetailedHeader");

                    b.Property<string>("HomeContent");

                    b.Property<string>("HomeHeader");

                    b.Property<string>("HomeImage");

                    b.HasKey("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");

                    b.HasData(
                        new { ArticleId = 1, CategoryId = 1, HomeContent = "A text describing this article", HomeHeader = "Watch: Attack in Syria" },
                        new { ArticleId = 2, CategoryId = 1, HomeContent = "A text describing this article", HomeHeader = "blah blah" }
                    );
                });

            modelBuilder.Entity("NewsNow.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, Name = "Politics" }
                    );
                });

            modelBuilder.Entity("NewsNow.Models.ExampleStatisticsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntersAmount");

                    b.Property<string>("OldestManName");

                    b.HasKey("ID");

                    b.ToTable("ExampleStatistics");
                });

            modelBuilder.Entity("NewsNow.Models.Article", b =>
                {
                    b.HasOne("NewsNow.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
