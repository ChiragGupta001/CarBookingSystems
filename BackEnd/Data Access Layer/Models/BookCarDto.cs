using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class BookCarDto
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Username { get; set; }
        public string Model { get; set; }
        public double PricePerHour { get; set; }
        public double TotalRent { get; set; }
    }
}
