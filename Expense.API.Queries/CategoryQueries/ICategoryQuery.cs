using Expenses.API.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.API.Queries.CategoryQueries
{
    public interface ICategoryQuery
    {
        public Task<List<CategoryModel>> GetCategoriesAsync();
        public Task<CategoryModel> GetCategoryAsync(int id);
        public Task<CategoryModel> AddCategoryAsync(CategoryModel model);
        public Task UpdateCategoryAsync(int id, EditCategoryModel updateModel);
        public Task DeleteCategoryAsync(int id);
    }
}
