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
    public class ApplicationMaper : Profile
    {
        public ApplicationMaper() {
            CreateMap<EditCategoryModel, ExpenseCategory>()
                .ForMember(dest => dest.CategoryName, otp => otp.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Description, otp => otp.MapFrom(src => src.Description))
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Expenses, otp =>otp.Ignore());
            CreateMap<ExpenseCategory, CategoryModel>();
        }
    }
}
