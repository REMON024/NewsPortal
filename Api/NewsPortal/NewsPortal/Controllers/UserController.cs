using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewPortal.BLL.Interface;
using NewsPortal.Common.Models;

namespace NewsPortal.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult> AddUser( User user)
        {
            try
            {
                return Ok(await _userService.AddUser(user));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

    }
}
