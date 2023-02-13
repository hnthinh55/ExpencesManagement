using Expense.API.Queries.CategoryQueries;
using Expenses.API.Models.CategoryModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryQuery _categoryQuery;

        public CategoryController(ICategoryQuery repo)
        {
            _categoryQuery = repo;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                return Ok(await _categoryQuery.GetAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var book = await _categoryQuery.GetIdAsync(id);
            return book == null ? NotFound() : Ok(book);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, EditCategoryModel category)
        {
            var checkValid = await _categoryQuery.GetIdAsync(id);

            if (checkValid == null)
            {
                return NotFound();
            }
            await _categoryQuery.UpdateAsync(id, category);
            return Ok(category);
        }

        // POST: api/Categories
        [HttpPost]
        public async Task<IActionResult> PostCategory(EditCategoryModel model)
        {
            try
            {
                var newCategory = await _categoryQuery.AddAsync(model);
                return newCategory == null ? NotFound() : Ok(newCategory);
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var checkValid = await _categoryQuery.GetIdAsync(id);
            if (checkValid == null)
                return BadRequest();
            await _categoryQuery.DeleteAsync(id);
            return Ok();
        }
    }
}
