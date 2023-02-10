using AutoMapper;
using Expenses.API.Models.CategoryModels;
using Expenses.API.Models.ExpenseDetailModels;
using Expenses.API.Models.ExpenseModels;
using Expenses.API.Models.UserModels;
using Expenses.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Access.Helpers
{
    public class CategoryMaper : Profile
    {
        public CategoryMaper() {
            CreateMap<ExpenseCategory, EditCategoryModel>()
                .ForMember(dest => dest.CategoryName, otp => otp.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Description, otp => otp.MapFrom(src => src.Description));
            CreateMap<ExpenseCategory, CategoryModel>()
                .ForMember(dest => dest.Id, otp => otp.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoryName, otp => otp.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Description, otp => otp.MapFrom(src => src.Description));
        }
    }
}
