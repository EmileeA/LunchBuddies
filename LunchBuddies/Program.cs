using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LunchBuddy> companions = new List<LunchBuddy> { };

            companions.Add(new LunchBuddy("Jane", "Doe"));
            companions.Add(new LunchBuddy("Jack", "Doe"));
            companions.Add(new LunchBuddy("Cookie", "Doe"));

            var lunchBuddy = new LunchBuddy("Pizza", "Doe");
            var resto = new Restaurant();


            lunchBuddy.Eat();
            lunchBuddy.EatFood("vietnamese");
            lunchBuddy.Eat(companions);
            lunchBuddy.Eat("indian", companions);

            // below code to make sure getting random restaurants
            //Console.WriteLine(resto.Name);
            //Console.ReadLine();

        }
    }
}
