using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class Factory
    {
        public abstract List<Product> MakeProducts();
        public void SendProductToStorage(List<Product> products)
        {
            foreach (var product in products) Storage.StorageContainer.Add(product);
        }
    }
}
