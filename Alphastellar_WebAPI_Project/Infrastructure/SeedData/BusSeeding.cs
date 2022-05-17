using Alphastellar_WebAPI_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar_WebAPI_Project.Infrastructure.SeedData
{
    public class BusSeeding : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.
                HasData(
                new Bus { Id = 1, Colour = "Black" },
                new Bus { Id = 2, Colour = "White" },
                new Bus { Id = 3, Colour = "Red" },
                new Bus { Id = 4, Colour = "Blue" },
                new Bus { Id = 5, Colour = "Red" },
                new Bus { Id = 6, Colour = "Blue" },
                new Bus { Id = 7, Colour = "White" },
                new Bus { Id = 8, Colour = "Black" });
        }
    }
}
