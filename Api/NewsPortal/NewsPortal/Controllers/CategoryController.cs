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
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("AddCategory")]
        public async Task<ActionResult> AddCategory(Category category)
        {
            try
            {
                return Ok(await _categoryService.AddCategory(category));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("UpdateCategory")]
        public async Task<ActionResult> UpdateCategory(Category category)
        {
            try
            {
                return Ok(await _categoryService.UpdateCategory(category));
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
                return Ok(await _categoryService.GetById(id));
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
                return Ok(await _categoryService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [HttpGet("GetAllCategory")]
        public async Task<ActionResult> GetAllCategory()
        {
            try
            {
                return Ok(await _categoryService.GetAllCategory());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

    }
}
