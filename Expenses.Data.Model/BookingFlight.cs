using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("BookingFlight")]
    public class BookingFlight
    {
        [Key]
        public string Id { get; set; }
        public string AirLineName { get; set; } = "VietNam Airline";
        [Required]
        public bool SeatType { get; set; }
        [Required(ErrorMessage = "Location from must be require")]
        public string LocationFrom { get; set; }
        [Required(ErrorMessage = "Location To must be require")]
        public string LocationTo { get; set; }
        [Required]
        public DateTime DateBegin { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }
        [Required(ErrorMessage = "Number of people must be require")]
        public int NumberPeople { get; set; }
        public decimal Price { get; set; }
    }
}
