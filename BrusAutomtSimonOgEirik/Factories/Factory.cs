using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class Factory
    {
        public abstract List<Product> MakeProducts();
        public abstract void SendProductToStorage(List<Product> products);
    }
}
