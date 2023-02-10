using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("ExpenseCategory")]
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<ExpenseDetail> Expenses { get; set; }
        public ExpenseCategory() => Expenses = new List<ExpenseDetail>();
    }
}
