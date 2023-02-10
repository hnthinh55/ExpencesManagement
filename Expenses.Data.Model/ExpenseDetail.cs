using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("ExpenseDetail")]
    public class ExpenseDetail
    {
        [Key]
        public string Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public decimal Amount { get; set; }
        [Required, MaxLength(150)]
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
        public int CategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
