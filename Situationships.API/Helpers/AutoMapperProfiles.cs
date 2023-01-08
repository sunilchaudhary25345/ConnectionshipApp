using AutoMapper;
using Situationships.API.DTOs;
using Situationships.API.Entities;
using Situationships.API.Extensions;

namespace Situationships.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
              .ForMember(dest => dest.PhotoUrl,
                    opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
              .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));      
            CreateMap<Photo, PhotoDto>();
        }
    }
}