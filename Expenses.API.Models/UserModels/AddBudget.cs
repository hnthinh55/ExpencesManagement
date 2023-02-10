using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.UserModels
{
    public class AddBudget
    {
        [Required]
        public decimal Budget { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
