using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.DTO
{
    public class BaseEntityDTO
    {
        public int ID { get; set; }
        public Guid Guid { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
