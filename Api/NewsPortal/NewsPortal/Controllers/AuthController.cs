using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewPortal.BLL.Interface;
using NewsPortal.Common.VM;

namespace NewsPortal.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("Login")]
        public async Task<ActionResult> Login(Login login)
        {
            try
            {
                return Ok(await _authService.Login(login));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
