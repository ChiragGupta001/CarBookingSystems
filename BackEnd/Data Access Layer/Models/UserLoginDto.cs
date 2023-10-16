using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class UserLoginDto
    {
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
