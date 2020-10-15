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
    [Route("api/comments")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost("AddComment")]
        public async Task<ActionResult> AddComment(Comments comments)
        {
            try
            {
                return Ok(await _commentService.AddComments(comments));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("UpdateComment")]
        public async Task<ActionResult> UpdateComment(Comments comments)
        {
            try
            {
                return Ok(await _commentService.UpdateComments(comments));
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
                return Ok(await _commentService.GetCommentsbyID(id));
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
                return Ok(await _commentService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [HttpGet("GetAllComment")]
        public async Task<ActionResult> GetAllComment()
        {
            try
            {
                return Ok(await _commentService.GetAllComments());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
