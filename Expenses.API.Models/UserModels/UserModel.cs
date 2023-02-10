using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.API.Models.UserModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UseName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Budget { get; set; }
        public int RoleId { get; set; }
    }
}
