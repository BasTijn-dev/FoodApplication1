using FoodApplication.Domain.Entities.FoodApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication.Application.Interfaces.Repositories
{
    public interface IFoodItemRepository : IRepository<FoodItem>
    {
        Task<IEnumerable<FoodItem>> GetAvailableFoodItemAsync();
    }
}
