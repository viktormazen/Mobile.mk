using AutoMapper;
using mobile.Domain.Models;
using mobile.WebModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace mobile.Services.Helpers
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserViewModel>();

            CreateMap<RegisterViewModel, User>()
                .ForMember(u => u.FullName, src => src.ResolveUsing(rm => $"{rm.FirstName} {rm.LastName}"))
                .ForMember(u => u.EmailConfirmed, src => src.UseValue(true));

            CreateMap<Vehicle, VehicleViewModel>()
                .ReverseMap()
                .ForMember(v => v.UserId, src => src.Ignore());

            CreateMap<VehicleCreateViewModel, Vehicle>()
                .ForMember(v => v.Images, src => src.Ignore());

            CreateMap<VehicleImage, VehicleImageViewModel>()
                .ForMember(vivm => vivm.Image, src => src.MapFrom(vi => vi.ImageString))
                .ReverseMap();
        }
    }
}
