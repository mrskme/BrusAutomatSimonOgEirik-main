using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class DrinksFactory : Factory
    {
        private List<Product> DrinksList;

        public override List<Product> MakeProducts()
        {
            DrinksList = new List<Product>
            {
                new Drink("glass", 460, 25, "Coca Cola", 32),
                new Drink("plastic", 500, 20, "Coca Cola", 20),
                new Drink("tin can", 330, 5, "Coca Cola", 72),
                new Drink("plastic", 500, 25, "Fanta Lemon", 40),
                new Drink("plastic", 500, 23, "Urge Intense", 15),
                new Drink("plastic", 500, 63, "Solo", 200),
                new Drink("tin can", 250, 2, "Solo", 25),
                new Drink("tin can", 500, 591, "Burn", 1),
            };
            return DrinksList;
        }

        public override void SendProductToStorage(List<Product> products)
        {
            foreach (var product in products) Storage.StorageContainer.Add(product);
        }
    }
}
