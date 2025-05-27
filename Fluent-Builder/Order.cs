using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Builder
{
    public class Order
    {
        public int Number { get; init; }
        public DateTime CreatedOn { get; init; }
        public Address ShippingAdress { get; set; }
    }
}
