using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.ExpenseModels
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Descrition { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
    }
}
