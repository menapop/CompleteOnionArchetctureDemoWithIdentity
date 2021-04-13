using Data.Entities;
using AutoMapper;
using DTOS.Dto;
using Repo;
using DTOS.UserDtos;
using DTOS;

namespace Service
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            
            CreateMap <Category, OutputCategoryDto>().ReverseMap();
            CreateMap<CreateUserDto,ApplicationUser>()
                .ForMember(src=>src.UserName,opt=>opt.MapFrom(dst=>dst.Email));
            CreateMap<OutputRefreshTokenDto, OutputSignInUserDto>().ReverseMap();
            
        }
    }
}
