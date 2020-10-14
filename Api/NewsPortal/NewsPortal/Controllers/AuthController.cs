using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewPortal.BLL.Interface;
using NewsPortal.Common.VM;
using NewsPortal.Helper;

namespace NewsPortal.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IGenerateToken _generateToken;
        public AuthController(IAuthService authService, IGenerateToken generateToken)
        {
            _authService = authService;
            _generateToken = generateToken;
        }


        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody] ApiCommonMessage requestMessage)
        {
            Login login = requestMessage.GetRequestObject<Login>();
            LoginReturn loginReturn = new LoginReturn();
            try
            {
                loginReturn = await _authService.Login(login);
                return Ok(await _generateToken.BuildToken(loginReturn));
            }
            catch (Exception ex)
            {
                loginReturn.Message = "Fail";
                return BadRequest(ex.Message);
            }

        }
    }
}
