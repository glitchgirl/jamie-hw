using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smith_week4.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options) : base(options) 
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<FAQs> FAQs { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId= "gen", Name= "General" },
                new Categories { CategoryId= "hist", Name= "History"}
            );
            modelBuilder.Entity<Topics>().HasData(
                new Topics { TopicId="cs",Name="C#"},
                new Topics { TopicId="js",Name="JavaScript"},
                new Topics { TopicId="boot",Name="Bootstrap"}
            );
            modelBuilder.Entity<FAQs>().HasData(
                new FAQs
                {
                    Id=1,
                    Answer= "A general purpose object oriented language that uses a concise, Java-like syntax",
                    CategoryId= "gen",
                    Question= "What is C#?",
                    TopicId="cs"
                },
                new FAQs
                {
                    Id = 2,
                    Answer = "In 2002.",
                    CategoryId = "hist",
                    Question = "When was C# first released?",
                    TopicId = "cs"
                },
                new FAQs
                {
                    Id = 3,
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    CategoryId = "gen",
                    Question = "What is JavaScript?",
                    TopicId = "js"
                },
                new FAQs
                {
                    Id = 4,
                    Answer = "In 1995.",
                    CategoryId = "hist",
                    Question = "When was JavaScript first released?",
                    TopicId = "cs"
                },
                new FAQs
                {
                    Id = 5,
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    CategoryId = "gen",
                    Question = "What is Bootstrap?",
                    TopicId = "boot"
                },
                new FAQs
                {
                    Id = 6,
                    Answer = "In 2011.",
                    CategoryId = "hist",
                    Question = "When was Bootstrap first released?",
                    TopicId = "boot"
                }
            );
        }
    }
}
