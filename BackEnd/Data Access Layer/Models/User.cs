using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class User : IdentityUser
    {
        public string Name {  get; set; }
        public string Password { get; set; }
        public string Profile { get; set; }

        public ICollection<BookCar> BookCars { get; set; }
    }
}
