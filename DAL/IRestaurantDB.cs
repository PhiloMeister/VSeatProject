﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRestaurantDB
    {
        public List<Restaurant> GetRestaurants();

        public Restaurant GetRestaurant(string name , string adress);

        public Restaurant addRestaurant(Restaurant restaurant);



    }
}
