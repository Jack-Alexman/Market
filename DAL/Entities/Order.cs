﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Order
    {
        public int OrderId { get; set; }
        public decimal Sum { get; set; }
        public Product Product { get; set; }
        public DateTime Date { get; set; }

    }
}
