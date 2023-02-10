using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.ExpenseDetailModels
{
    public class EditDetailModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public decimal Amount { get; set; }
        [Required, MaxLength(150)]
        public string Comment { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
