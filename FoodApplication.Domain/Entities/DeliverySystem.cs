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
        public string DispatchRiderPhoneNumber { get; set; }
        public Order FoodOrders { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DeliveryStatus Status { get; set; }
    }

        public enum DeliveryStatus 
        {
            Accepted,
            Declined,
            InTransit,
            Pending,
        }
}
