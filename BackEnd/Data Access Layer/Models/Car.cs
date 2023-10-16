using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CarId { get; set; }
        [Required]
        public string Model { get; set; }   
        public string Brand {  get; set; }
        public double PricePerHour { get; set; }
        public string Description { get; set; }
        public bool IsBook { get; set; }    
        
    }
}
