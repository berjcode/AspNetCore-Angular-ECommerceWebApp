using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Order:BaseEntity
    {


        public int CustomerId { get; set; }
        public int Description{ get; set; }

        public string Address { get; set; }

        
        //Bir siparişin birden fazla ürünü olabilir.
        public ICollection<Product> Products { get; set; }

        //bir tane müşterin olabailir.

        public Customer Customer { get; set; }

    }
}
