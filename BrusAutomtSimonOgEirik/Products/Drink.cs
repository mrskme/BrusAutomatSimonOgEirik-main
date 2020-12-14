using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Drink : Product
    {

        private readonly int Size;
        private readonly string Material;
        public Drink(string material, int size, double price, string name, int storage) : base(price, name, storage)
        {
            Size = size;
            Material = material;
        }
    }
}
