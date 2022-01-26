using BlueSchedule.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlueSchedule.Infrastructure.Context
{
    public class BlueScheduleDbContext : DbContext
    {
        public BlueScheduleDbContext(DbContextOptions options): base(options){ }

        public DbSet<ItemEntity> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemEntity>().HasData(
                new ItemEntity
                {
                    Id = Guid.NewGuid(),
                    Title = "Test Item",
                    Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    Responsible = "Rodolfo Dias",
                    StartDate = DateTime.UtcNow,
                    EndDate = null
                });
        }
    }
}