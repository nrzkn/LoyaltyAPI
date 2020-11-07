using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.DTO
{
    public class StoreDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Point { get; set; }
        public int OwnerId { get; set; }
    }
}
