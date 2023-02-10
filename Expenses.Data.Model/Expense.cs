using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenses.Data.Model
{
    [Table("Expenses")]
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Descrition { get; set; }
        public decimal Amount { get; set; } 
        public string? Comment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ExpenseDetail> Details { get; set; }
        public Expense() {
            Details= new List<ExpenseDetail>();
        }

    }
}