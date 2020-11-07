using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.DTO
{
    public class CustomerDTO : BaseEntityDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PersonalID { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public decimal Point { get; set; }
    }
}
