using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("BudgetReport")]
    public class BudgetReport
    {
        [Key]
        public string Id { get; set; }
        public decimal TotalPay { get; set; }
        public decimal BudgetRemain { get; set; }
        [Required]
        public decimal OldBudget { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
