using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoLaTengo.Dtos;
using NoLaTengo.Models;
using NoLaTengo.Services;

namespace NoLaTengo.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CategoryController: ControllerBase {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryService.GetAllCategories());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await _categoryService.GetCategoryById(id));

        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryDto newCategory)
        {
           return Ok(await _categoryService.AddCategory(newCategory));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updatedCategory)
        {
            ServiceResponse<GetCategoryDto> response = await _categoryService.UpdateCategory(updatedCategory);

            if(response.Data == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            ServiceResponse<List<GetCategoryDto>> response = await _categoryService.DeleteCategory(id);

            if (response.Data == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }


    }
}