using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    // Create a new class to represent a Restaurant.
    class Restaurant
    {
        // It should have a private property that contains a List of restaurant names. List<string>
        private List<string> _restaurantNames = new List<string> { "Taj", "Vuis", "Pizza Hut" };
        // It's constructor should pick a random restaurant name and assign it to a public property called "Name"
        public string Name { get; set; }

        public Restaurant()
        {
            Random rnd = new Random();

            int restoNum = rnd.Next(3);
            Name = _restaurantNames[restoNum];
        }

    }
}
