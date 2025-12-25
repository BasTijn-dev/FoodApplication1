using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    public class List : Audit
    {
        public string FoodName { get; set; }
        public bool IsAvailable { get; set; }
    }
}
