using Alphastellar_WebAPI_Project.Models.DTOs;
using Alphastellar_WebAPI_Project.Models.Entities;
using Alphastellar_WebAPI_Project.Models.VMs;
using AutoMapper;

namespace Alphastellar_WebAPI_Project.Infrastructure
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Car, UpdateCarDTO>().ReverseMap();
            CreateMap<Car, GetCarsVM>().ReverseMap();
            CreateMap<GetCarsVM, UpdateCarDTO>().ReverseMap();

            CreateMap<Boat, GetBoatsVM>().ReverseMap();

            CreateMap<Bus, GetBusesVM>().ReverseMap();
        }
    }
}
