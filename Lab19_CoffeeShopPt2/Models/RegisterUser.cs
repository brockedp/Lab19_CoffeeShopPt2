using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab19_CoffeeShopPt2.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "UserName must be 5 to 30 characters long and only letters and numbers")]
        [RegularExpression(@"^([A-Za-z0-9]{1,30})$")]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }

        public DateTime Birthday { get; set; }

        public string Drink { get; set; }

        [Required(ErrorMessage = "Must be an email that is at 5 characters long and contains an @")]
        [RegularExpression(@"^([A-Za-z0-9]{1,30})@([A-Za-z0-9]{1,10}).([A-Za-z0-9]{2,3})$")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password must be 5 to 30 characters long and only letters and numbers")]
        [RegularExpression(@"^([A-Za-z0-9]{1,30})$")]
        public string Password { get; set; }


        public enum DrinkOfChoice
        {
            coffee,
            tea,
            latte,
            cappucino
        };

    }
}
