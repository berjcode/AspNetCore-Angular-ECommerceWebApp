﻿using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{



   public class Customer:BaseEntity
    {

        public string Name { get; set; }



        //bir müşterinin birden fazla siparişi olabilir.
        public ICollection<Order> Orders { get; set; }
    }
}