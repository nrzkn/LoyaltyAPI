using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Core.Domain
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Point  { get; set; }
        public int OwnerId { get; set; }

        public Owner Owner { get; set; }
        public virtual ICollection<CustomersStores> CustomersStores { get; set; }
    }
}
