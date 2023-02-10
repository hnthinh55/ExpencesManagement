using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UseName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required, MinLength(8)]
        public string Password { get; set; }
        public decimal Budget { get; set; }
        public bool IsDelete { get; set; }
        public int RoleId { get; set; }
        public Role Roles { get; set; }
        public BudgetReport BudgetReport { get; set; }
        public User()
        {
            Budget = 0;
        }
    }
}
