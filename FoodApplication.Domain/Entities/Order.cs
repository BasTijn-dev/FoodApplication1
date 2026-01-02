using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    public class Order : Audit
    {
        public string CustomerName { get; set; }
        public Customer CustomerId  { get; set; }
        public Customer Customer { get; set; }
        public DeliverySystem DeliverySystem{get;set; }
        public ICollection<FoodItem> FoodItems { get; set; }

    }
}
