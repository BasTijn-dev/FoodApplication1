using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Domain.Entities
{
    public abstract class Audit
    {
        public Guid Id { get; set; }               // Primary Key
        public DateTime CreatedOn { get; set; }    // Auto-set on insert
        public bool IsDeleted { get; set; }         // Soft delete flag
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }

    }

}
