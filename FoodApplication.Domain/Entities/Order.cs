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
        public ICollection<List> FoodList { get; set; }
        public DeliverySystem DeliveryId{get;set; } 
    }
}
