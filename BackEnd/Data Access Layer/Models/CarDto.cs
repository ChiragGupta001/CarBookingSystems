using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class CarDto
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double PricePerHour { get; set; }
        public string Description { get; set; }
    }
}
