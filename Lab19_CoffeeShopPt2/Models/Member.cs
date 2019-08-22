using System;
using System.Collections.Generic;

namespace Lab19_CoffeeShopPt2.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Drink { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Funds { get; set; }
    }
}
