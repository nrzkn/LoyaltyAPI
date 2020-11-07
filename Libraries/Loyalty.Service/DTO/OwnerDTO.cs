using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.DTO
{
    public class OwnerDTO : BaseEntityDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string PersonelID { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public decimal Point { get; set; }
    }
}
