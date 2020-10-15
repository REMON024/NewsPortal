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
    [Route("api/feed]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly IFeedService _feedService;

        public FeedController(IFeedService feedService)
        {
            _feedService = feedService;
        }

        [HttpPost("AddFeed")]
        public async Task<ActionResult> AddFeed(Feed feed)
        {
            try
            {
                return Ok(await _feedService.AddFeed(feed));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("UpdateFeed")]
        public async Task<ActionResult> UpdateFeed(Feed feed)
        {
            try
            {
                return Ok(await _feedService.UpdateFeed(feed));
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
                return Ok(await _feedService.GetById(id));
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
                return Ok(await _feedService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [HttpGet("GetAllFeed")]
        public async Task<ActionResult> GetAllFeed()
        {
            try
            {
                return Ok(await _feedService.GetAllFeed());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
