using DTOS.Dto;
using DTOS.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _UserService;
        public AccountController(IUserService UserService)
        {
            _UserService = UserService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddUser(CreateUserDto createUserDto)
        {

            return Ok(await _UserService.CreateUser(createUserDto));
        }
        [HttpPost]
        public async Task<ActionResult<OutputSignInUserDto>> SignIn(InputSignInUserDto inputSignInUserDto)
        {

            return Ok(await _UserService.SignInAsync(inputSignInUserDto));
        }
    }
}
