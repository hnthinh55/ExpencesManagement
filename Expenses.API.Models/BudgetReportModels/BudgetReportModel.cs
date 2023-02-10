using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.BudgetReportModels
{
    public class BudgetReportModel
    {
        public string Id { get; set; }
        public decimal TotalPay { get; set; }
        public decimal BudgetRemain { get; set; }
        public decimal OldBudget { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
