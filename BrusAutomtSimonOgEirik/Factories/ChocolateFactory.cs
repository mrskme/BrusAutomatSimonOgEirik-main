using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class ChocolateFactory : Factory
    {
        private List<Product> CandyList;

        public override List<Product> MakeProducts()
        {
            CandyList = new List<Product>
            {
                new Chocolate(false,50, "Mars", 2),
                new Chocolate(true, 9001, "Twix", 20),
                new Chocolate(false, 2, "Snickers", 22),
                new Chocolate(false, 51, "Monolith", 235),
                new Chocolate(true, 39, "White Lion", 1),
                new Chocolate(false, 90, "Dark Lion", 9001),
            };
            return CandyList;
        }

        //public override void SendProductToStorage(List<Product> products)
        //{
        //    foreach (var product in products) Storage.StorageContainer.Add(product);
        //}

    }
}
