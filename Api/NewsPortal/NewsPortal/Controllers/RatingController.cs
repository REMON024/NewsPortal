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
    [Route("api/rating")]
    [ApiController]
    public class RatingController : ControllerBase
    {

        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost("AddRating")]
        public async Task<ActionResult> AddRating(Rating rating)
        {
            try
            {
                return Ok(await _ratingService.AddRating(rating));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("UpdateRating")]
        public async Task<ActionResult> UpdateRating(Rating rating)
        {
            try
            {
                return Ok(await _ratingService.UpdateRating(rating));
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
                return Ok(await _ratingService.GetById(id));
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
                return Ok(await _ratingService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [HttpGet("GetAllRating")]
        public async Task<ActionResult> GetAllRating()
        {
            try
            {
                return Ok(await _ratingService.GetAllRating());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
