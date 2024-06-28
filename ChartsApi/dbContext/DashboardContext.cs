using ChartsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChartsApi.dbContext
{
    public class DashboardContext : DbContext
    {
        public DbSet<DashboardWidget> DashboardWidgets { get; set; }

        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var stringArrayConverter = new ValueConverter<string[], string>(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            var stringArrayComparer = new ValueComparer<string[]>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToArray());

            modelBuilder.Entity<DashboardWidget>()
                .Property(d => d.Labels)
                .HasConversion(stringArrayConverter)
                .Metadata.SetValueComparer(stringArrayComparer);

            modelBuilder.Entity<DashboardWidget>()
                .Property(d => d.DatasetData)
                .HasConversion(stringArrayConverter)
                .Metadata.SetValueComparer(stringArrayComparer);

            modelBuilder.Entity<DashboardWidget>()
                .Property(d => d.BackgroundColor)
                .HasConversion(stringArrayConverter)
                .Metadata.SetValueComparer(stringArrayComparer);

            // Seed data
            modelBuilder.Entity<DashboardWidget>().HasData(
                new DashboardWidget
                {
                    Id = 1,
                    ChartType = "pie",
                    PositionRow = 0,
                    PositionCol = 0,
                    SizeRows = 2,
                    SizeCols = 3,
                    Labels = new[] { "A", "B", "C" },
                    DatasetLabel = null,
                    DatasetData = new[] { "300", "50", "100" },
                    BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" },
                    BorderColor = null,
                    Fill = null
                },
                new DashboardWidget
                {
                    Id = 2,
                    ChartType = "bar",
                    PositionRow = 0,
                    PositionCol = 9,
                    SizeRows = 2,
                    SizeCols = 3,
                    Labels = new[] { "January", "February", "March" },
                    DatasetLabel = "Sales",
                    DatasetData = new[] { "65", "59", "80" },
                    BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" },
                    BorderColor = null,
                    Fill = null
                },
                new DashboardWidget
                {
                    Id = 3,
                    ChartType = "line",
                    PositionRow = 2,
                    PositionCol = 0,
                    SizeRows = 2,
                    SizeCols = 3,
                    Labels = new[] { "January", "February", "March" },
                    DatasetLabel = "Sales",
                    DatasetData = new[] { "65", "59", "80" },
                    BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" },
                    BorderColor = "#4bc0c0",
                    Fill = false
                }
            );
        }
    }

}
