using System;
using System.Collections.Generic;


namespace Assignments_3._4._1
{
    public class CoffeeRepository
    {
        private readonly List<Coffee> coffeeList;

        public CoffeeRepository()
        {
            coffeeList = new List<Coffee>
            {
                new Coffee { BevId = 1, Brand = "Starbucks", VolumeInOz = 20, Roast = RoastType.Dark, IsDecaf = false},
                new Coffee { BevId = 2, Brand = "Dunkins", VolumeInOz = 8, Roast = RoastType.Medium, IsDecaf = true},
                new Coffee { BevId = 3, Brand = "Petes", VolumeInOz = 16, Roast = RoastType.Medium_Dark, IsDecaf = false},
                new Coffee { BevId = 4, Brand = "Olympia Coffee", VolumeInOz = 12, Roast = RoastType.Light, IsDecaf = true},
                new Coffee { BevId = 5, Brand = "Starbucks", VolumeInOz = 8, Roast = RoastType.Dark, IsDecaf = false}
            };
        }
        public List<Coffee> GetAllCoffee()
        {
            return coffeeList;
        }

        public void AddCoffee(Coffee coffee)
        {
            coffeeList.Add(coffee);
        }

        public void RemoveCoffee()
        {
            coffeeList.RemoveAt(coffeeList.Count - 1);
        }
    }
}
