using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGRProject.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int PlaceId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public DateTime? BookingStart { get; set; }
        public DateTime? BookingFinish { get; set; }
        public int? Rating { get; set; }
        public int Status { get; set; }
    }
}
