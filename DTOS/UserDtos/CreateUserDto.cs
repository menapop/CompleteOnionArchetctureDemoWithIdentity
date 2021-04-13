using System;
using System.Collections.Generic;
using System.Text;

namespace DTOS.UserDtos
{
    public class CreateUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Roles { get; set; }
       
    }
}
