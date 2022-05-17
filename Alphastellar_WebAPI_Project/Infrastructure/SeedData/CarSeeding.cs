using Alphastellar_WebAPI_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar_WebAPI_Project.Infrastructure.SeedData
{
    public class CarSeeding : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.
                HasData(
                new Car { Id = 1, Colour = "Red", Headlights = "On", Wheels = 4 },
                new Car { Id = 2, Colour = "Blue", Headlights = "Off", Wheels = 4 },
                new Car { Id = 3, Colour = "Black", Headlights = "Off", Wheels = 4 },
                new Car { Id = 4, Colour = "White", Headlights = "Off", Wheels = 4 },
                new Car { Id = 5, Colour = "Red", Headlights = "Off", Wheels = 4 },
                new Car { Id = 6, Colour = "Blue", Headlights = "On", Wheels = 4 },
                new Car { Id = 7, Colour = "Black", Headlights = "On", Wheels = 4 },
                new Car { Id = 8, Colour = "White", Headlights = "Off", Wheels = 4 });
        }
    }
}
