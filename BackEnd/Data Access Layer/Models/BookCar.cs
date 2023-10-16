using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class BookCar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookCarId { get; set; }
        public DateTime To { get; set; }
        public DateTime From { get; set; }
        public double TotalRent { get; set; }

        public Guid CarId { get; set; }
        public Car Car { get; set; }

        public string Id { get; set; }
        [ForeignKey("Id")]
        public User User { get; set; }
    }
}
