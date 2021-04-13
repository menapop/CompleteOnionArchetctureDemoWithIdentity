using DTOS.Dto;
using DTOS.UserDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    public interface IUserService 
    {
        Task<bool> CreateUser(CreateUserDto createUserDto);
        Task<OutputSignInUserDto> SignInAsync(InputSignInUserDto inputSignInUserDto);
    }
}
