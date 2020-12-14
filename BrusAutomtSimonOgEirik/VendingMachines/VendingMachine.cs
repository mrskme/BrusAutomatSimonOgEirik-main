using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class VendingMachine : Transactions
    {
        public abstract Product ChooseSoda(string product);
        internal abstract void SpitOutProduct(Product chosenProduct);
        public abstract string ShowProductList();
    }
}
