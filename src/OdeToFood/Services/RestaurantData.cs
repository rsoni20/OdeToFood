using OdeToFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Abhiruchi"},
                new Restaurant { Id = 2, Name = "Pakwan"},
                new Restaurant { Id = 3, Name = "Bawarchi"},
                new Restaurant { Id = 4, Name = "Shah Ghouse"},
                new Restaurant { Id = 5, Name = "Waffels"},

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
