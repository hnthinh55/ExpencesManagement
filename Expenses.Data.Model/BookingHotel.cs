using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("BookingHotel")]
    public class BookingHotel
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string HotelName { get; set; }
        public string Location { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DayCheckIn { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DayCheckOut { get; set;}
        [Required]
        public int NumberPeople { get; set; } = 1;
        [Required]
        public int NumberRoom { get; set; } = 1;
        public decimal Price { get; set; }
    }
}
