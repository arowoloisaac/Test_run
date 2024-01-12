﻿using Arowolo_Delivery_Project.Enums;
using Microsoft.AspNetCore.Identity;
using startup_trial.Models;

namespace Arowolo_Delivery_Project.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; } = Gender.Male;

        public string Address { get; set; } = string.Empty;

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<Basket> BasketList { get; set; } = new List<Basket>();
        public ICollection<Order> OrderList { get; set; } = new List<Order>();

        public ICollection<RestaurantRating> Restaurants { get; set; } = new List<RestaurantRating>();  
    }
}