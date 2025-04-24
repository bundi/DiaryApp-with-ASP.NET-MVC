using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1, 
                    Title="Went Hiking", 
                    Content="Went Hiking with Mike", 
                    Created = new DateTime(2025, 1, 1)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went to Studium",
                    Content = "Went to watch football with Mike",
                    Created = new DateTime(2022, 1, 1)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Shopping",
                    Content = "Went shopping with Mike",
                    Created = new DateTime(2023, 1, 1)
                },
                new DiaryEntry
                {
                    Id = 4,
                    Title = "Went to Swimming poool",
                    Content = "I went to the swimming pool with Joe",
                    Created = new DateTime(2024, 1, 1)
                }
                );
        }
    }
}
