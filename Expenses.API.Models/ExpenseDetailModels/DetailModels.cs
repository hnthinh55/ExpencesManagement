using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.ExpenseDetailModels
{
    public class DetailModels
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
