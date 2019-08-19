using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19_CoffeeShopPt2.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "UserName must be 5 to 30 characters long")]
        [RegularExpression(@"^([A-Za-z0-9]{5,30})$")]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }

        public DateTime Birthday { get; set; }

        public string Drink { get; set; }

        [Required]
        [RegularExpression(@"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})$")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password must be 5 to 30 characters long")]
        [RegularExpression(@"^([A-Za-z0-9]{5,30})$")]
        public string Password { get; set; }


        

    }
}
