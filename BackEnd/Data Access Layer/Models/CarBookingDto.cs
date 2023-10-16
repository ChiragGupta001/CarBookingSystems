using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class CarBookingDto
    {
        public DateTime To { get; set; }
        public DateTime From { get; set; }  
        public Guid CarId { get; set; }
        public Guid Id { get; set; }    
    }
}