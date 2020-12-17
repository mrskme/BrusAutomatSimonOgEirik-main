using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    abstract class VendingMachine : Transactions
    {
        public abstract Response ChooseSoda(string product);
        internal abstract void SpitOutProductOrError(Response response);
        public abstract string ShowProductList();
    }
}
