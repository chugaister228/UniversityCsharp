﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models.Entities
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public BaseEntity() { ID = Guid.NewGuid(); CreatedDateTime = DateTime.Now; UpdateDateTime = null; }
    }
}
