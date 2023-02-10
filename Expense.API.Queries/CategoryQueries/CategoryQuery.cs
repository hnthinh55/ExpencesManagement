using AutoMapper;
using Expenses.API.Models.CategoryModels;
using Expenses.Data.Access.DataAccess;
using Expenses.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.API.Queries.CategoryQueries
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public CategoryQuery(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CategoryModel> AddCategoryAsync(CategoryModel model)
        {
            //var newCategory = _mapper.Map<ExpenseCategory>(model);
            //_context.ExpenseCategories!.Add(newCategory);
            //await _context.SaveChangesAsync();
            //return _mapper.Map<CategoryModel>(newCategory);
            var newCategory = new ExpenseCategory
            {
                Id = model.Id,
                CategoryName = model.CategoryName,
                Description = model.Description,
            };
            _context.Add(newCategory);
            _context.SaveChanges();
            return model;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var delete = _context.ExpenseCategories!.SingleOrDefault(x => x.Id == id);
            if (delete != null)
            {
                _context.ExpenseCategories!.Remove(delete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var categories = await _context.ExpenseCategories!.ToListAsync();
            return _mapper.Map<List<CategoryModel>>(categories);
        }

        public async Task<CategoryModel> GetCategoryAsync(int id)
        {
            var category = await _context.ExpenseCategories!.FindAsync(id);
            return _mapper.Map<CategoryModel>(category);
        }

        public async Task UpdateCategoryAsync(int id, EditCategoryModel updateModel)
        {
            var check = _context.ExpenseCategories!.SingleOrDefault(x => x.Id == id);
            if (check != null)
            {
                var updatebook = _mapper.Map<ExpenseCategory>(updateModel);
                _context.ExpenseCategories!.Update(updatebook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
