using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
   public class Address : Audit
    {
        public string CustomerAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        
    }
}
