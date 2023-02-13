using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model
{
    [Table("BookingTrip")]
    public class BookingTrip
    {
        [Key]
        public string Id { get; set; }
        public DateTime DateStart { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public int NumberPeople { get; set; }
        public decimal TotalPrice { get; set; }
        public int? FightId { get; set; }
        public int? HotelId { get; set; }
        public bool Status { get; set; }
        public BookingFlight? BookingFlight { get; set; }
        public BookingHotel? BookingHotel { get; set; }

    }
}
