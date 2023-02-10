using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.BudgetReportModels
{
    public class EditReportModel
    {
        [Required, Range(0.01, int.MaxValue)]
        public decimal TotalPay { get; set; }
        [Required, Range(0.01, int.MaxValue)]
        public decimal BudgetRemain { get; set; }
        [Required, Range(0.01, int.MaxValue)]
        public decimal OldBudget { get; set; }
    }
}
