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

        public async Task<CategoryModel> AddAsync(EditCategoryModel model)
        {
            var newCategory = _mapper.Map<EditCategoryModel,ExpenseCategory>(model);
            _context.ExpenseCategories.Add(newCategory);
            await _context.SaveChangesAsync();
            return _mapper.Map<ExpenseCategory,CategoryModel>(newCategory);

        }

        public async Task DeleteAsync(int id)
        {
            var delete = _context.ExpenseCategories!.SingleOrDefault(x => x.Id == id);
            if (delete != null)
            {
                _context.ExpenseCategories!.Remove(delete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<CategoryModel>> GetAsync()
        {
            var categories = await _context.ExpenseCategories!.ToListAsync();
            return _mapper.Map<List<CategoryModel>>(categories);
        }

        public async Task<CategoryModel> GetIdAsync(int id)
        {
            var category = await _context.ExpenseCategories!.FindAsync(id);
            return _mapper.Map<CategoryModel>(category);
        }

        public async Task UpdateAsync(int id, EditCategoryModel updateModel)
        {
            var check = _context.ExpenseCategories!.SingleOrDefault(x => x.Id == id);
            if (check != null)
            {
                var update = _mapper.Map<ExpenseCategory>(updateModel);
                _context.ExpenseCategories!.Update(update);
                await _context.SaveChangesAsync();
            }
        }
    }
}
