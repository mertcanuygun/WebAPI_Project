using Alphastellar_WebAPI_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar_WebAPI_Project.Infrastructure.SeedData
{
    public class BoatSeeding : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.
                HasData(
                new Boat { Id = 1, Colour = "Blue" },
                new Boat { Id = 2, Colour = "Black" },
                new Boat { Id = 3, Colour = "White" },
                new Boat { Id = 4, Colour = "Red" },
                new Boat { Id = 5, Colour = "Black" });
        }
    }
}
