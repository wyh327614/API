﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int GoodsId { get; set; }
        public int OrderNum { get; set; }
        public string AddressId { get; set; }
        public string OrderState { get; set; }
    }
}
