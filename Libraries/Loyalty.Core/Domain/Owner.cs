﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Core.Domain
{
    public class Owner : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string PersonelID { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public decimal Point { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
