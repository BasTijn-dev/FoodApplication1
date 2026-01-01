using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    namespace FoodApplication.Domain.Entities
    {
        public class FoodItem : Audit
        {
            public string FoodName { get; set; }
            public bool IsAvailable { get; set; }
            public decimal Price { get; set; }
            public ICollection<Order> Orders { get; set; }
        }
    }

}
