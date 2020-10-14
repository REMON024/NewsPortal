using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace NewsPortal.Helper
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class Authorize : AuthorizeAttribute, IAuthorizationFilter
    {
        private string[] AllowedPermissions { get; set; }

        public Authorize()
        {
            AllowedPermissions = null;
        }

        public Authorize(string someFilterParameter)
        {
            AllowedPermissions = someFilterParameter.Split(',');
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (!context.Filters.Contains(new AllowAnnonymous()))
            {
                if (!user.Identity.IsAuthenticated)
                {
                    context.Result = new ObjectResult("Access deny") { StatusCode = (int)HttpStatusCode.Unauthorized };
                    return;
                }
                else
                {
                    if (AllowedPermissions != null)
                    {
                        if (!isAuthorized(context))
                        {
                            context.Result = new ObjectResult("Forbidder") { StatusCode = (int)HttpStatusCode.Forbidden };
                            return;
                        }
                    }

                    return;
                }
            }
        }

        private bool isAuthorized(AuthorizationFilterContext context)
        {
            foreach (var perm in AllowedPermissions)
            {
                if (HasPermission(perm, context.HttpContext))
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasPermission(string permission, HttpContext context)
        {
            var result = context.User.IsInRole(permission);
            return result;
        }
    }
}
