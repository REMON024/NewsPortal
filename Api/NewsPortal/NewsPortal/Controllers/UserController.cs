using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewPortal.BLL.Interface;
using NewsPortal.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

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

        [HttpPost("UpdateUser")]
        public async Task<ActionResult> UpdateUser(User user)
        {
            try
            {
                return Ok(await _userService.UpdateUser(user));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _userService.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _userService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        //[Authorize]
        [HttpGet("GetAllUser")]
        public async Task<ActionResult> GetAllUser()
        {
            try
            {
                return new OkObjectResult(await _userService.GetAllUser());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

    }
}
