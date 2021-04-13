using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Filters
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class SecurityClaimFilter : AuthorizeAttribute, IAuthorizationFilter
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

      
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // implmentation here 
        }
    }
}
