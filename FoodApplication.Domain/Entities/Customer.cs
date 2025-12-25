using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    public class Customer : Audit
    {
        public string FirstName { get; set; }
        public string LastName{get;set; }
        public string EmailAddress { get; set; }
        public long PhoneNumber { get; set; }
        public Address CustomerAddressId { get; set; }
        public ICollection<Address> CustomerAddress {  get; set; }
        public ICollection<DeliverySystem> Delivery { get; set; }
        public ICollection<Order> FoodOrders { get; set; }
    }
}
