using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Core.Domain
{
    public class CustomersStores
    {
        public int StoreId { get; set; }
        public int CustomerId { get; set; }

        public Store Store { get; set; }
        public Customer Customer { get; set; }
    }
}
