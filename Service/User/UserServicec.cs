using AutoMapper;
using DTOS.Dto;
using DTOS.UserDtos;
using Microsoft.AspNetCore.Identity;
using Repo;
using Service.Helpers.Token;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    public class UserServicec : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager; 
        private readonly IMapper _mapper;
        private readonly ITokenHandler _tokenHandler;
        public UserServicec(UserManager<ApplicationUser> userManager, ITokenHandler tokenHandler, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
            _tokenHandler = tokenHandler;
        }
        public async Task<bool> CreateUser(CreateUserDto createUserDto)
        {
            var Appuser = _mapper.Map<ApplicationUser>(createUserDto);
            var AddUserResult = await _userManager.CreateAsync(Appuser, createUserDto.Password);
            if(AddUserResult.Succeeded)
            {
                //var AddUserRolesResult = await _userManager.AddToRolesAsync(Appuser, createUserDto.Roles);
                //if (AddUserRolesResult.Succeeded)
                //    return true;
                return true;
            }
            return false;
        }

        public async  Task<OutputSignInUserDto> SignInAsync(InputSignInUserDto inputSignInUserDto)
        {
            var user = await _userManager.FindByEmailAsync(inputSignInUserDto.Email);

            // return null if email and password isn't correct 
            if (user == null || ! (await _userManager.CheckPasswordAsync(user, inputSignInUserDto.Password)))
            {
                return null;
            }

            // get token for the user 
            OutputSignInUserDto outputSignInUserDto = _mapper.Map<OutputSignInUserDto>(_tokenHandler.GetToken(user));
            // update the refresh token for the  user 
            user.RefreshToken = outputSignInUserDto.RefreshToken;
            await _userManager.UpdateAsync(user);
          
            outputSignInUserDto.Name = user.Email;
            return outputSignInUserDto;
        }
    }
}
