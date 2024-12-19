using Microsoft.AspNetCore.Mvc;
using POS.Application.Dto.Request;
using POS.Application.Interfaces;
using POS.Infrastructure.Commons.Base.Request;

namespace POS.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryApplication _categoryApplication;

        public CategoryController(ICategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }


        [HttpPost]
        public async Task<IActionResult> ListCategories([FromBody] BaseFilterRequest filters)
        {
            var response = await _categoryApplication.ListCategories(filters);

            return Ok(response);
        }

        [HttpGet("Select")]
        public async Task<IActionResult> SelectCategories()
        {
            var response = _categoryApplication.ListSelectCategories();
            return Ok(response);
        }

        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult> CategoryById(int categoryId)
        {
            var response = await _categoryApplication.CategoryById(categoryId);

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterCategory([FromBody] CategoryRequestDTO requestDto)
        {
            var response = await _categoryApplication.RegisterCategory(requestDto);
            return Ok(response);

        }

        [HttpPut("Edit/{categoryId:int}")]
        public async Task<IActionResult> EditCategory(int categoryId, [FromBody] CategoryRequestDTO requestDto)
        {
            var response = await _categoryApplication.EditCategory(categoryId, requestDto);
            return Ok(response);

        }

        [HttpPut("register")]
        public async Task<IActionResult> RemoveCategory(int categoryId)
        {
            var response = await _categoryApplication.RemoveCategory(categoryId);
            return Ok(response);

        }

    }
}
