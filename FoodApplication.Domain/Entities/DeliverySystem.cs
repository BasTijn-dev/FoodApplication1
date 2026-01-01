using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    public class DeliverySystem : Audit
    {
        public string DispatchRiderName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }


    public enum DeliveryStatus 
        {
            Accepted,
            Declined,
            InTransit,
            Pending,
        }
}
