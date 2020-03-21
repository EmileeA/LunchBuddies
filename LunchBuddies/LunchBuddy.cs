using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    // 1. Create a new class to represent a LunchBuddy.
    class LunchBuddy
    {
        // 1.1  1.2 Its constructor should accept two parameters.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // 3. Define a method on your LunchBuddy class named eat() that will allow it to be invoked with the following four signatures.
        // 3.1 eat() - Will select a random restaurant name from a list of strings (List of restaurant names can come from anywhere), print to console that the buddy is at that restaurant, and also return the restaurant.
        public void Eat()
        {
            // instantiate Restaurant constructor so can have access to private list of restaurants
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is in the {restaurant.Name} restaurant");
        }
        //3.2 eat(string food) - Will output that the buddy ate that specific food at the office.
        public void EatFood(string food)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating {food} in the {restaurant.Name}");
        }
        // 3.3 eat(List<LunchBuddy> companions) - Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant, and also output the first name of each lunch buddy in the specified list.
        public void Eat(List<LunchBuddy> companions)
        {
            var resto = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at the {resto.Name} restaurant.");
            foreach (var comp in companions)
            {
                Console.WriteLine($"{comp.FirstName}");
            }
        }
        // 3.4 eat(string food, List<LunchBuddy> companions) - Will select a random restaurant name from a list of strings, print to console that the buddy at that restaurant, and ordered the specified food, with the first name of the teammates specified in the list.
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            foreach (var friend in companions)
            {
                Console.WriteLine($"{FirstName} {LastName} is at the {restaurant.Name} ordered {food} with {friend.FirstName}");
            }
        }
}
