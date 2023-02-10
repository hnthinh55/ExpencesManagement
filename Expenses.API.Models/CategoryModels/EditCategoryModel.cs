﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.CategoryModels
{
    public class EditCategoryModel
    {
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
