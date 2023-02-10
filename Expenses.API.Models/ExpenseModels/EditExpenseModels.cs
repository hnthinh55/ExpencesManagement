using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.ExpenseModels
{
    public class EditExpenseModels
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.01, int.MaxValue)]
        public decimal Amount { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
