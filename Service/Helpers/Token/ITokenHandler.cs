using DTOS;
using Repo;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Service.Helpers.Token
{
   public  interface ITokenHandler
    {
        OutputRefreshTokenDto GetToken(ApplicationUser user);

        IEnumerable<Claim> GetTokenClaims(string token);
    }
}
