using System;
using System.Collections.Generic;
using System.Text;
using BrusAutomatSimonOgEirik;

namespace BrusAutomtSimonOgEirik
{
    class ChocolateMachine : VendingMachine
    {
        public List<Product> _machineStorage = new List<Product>();
        public override Response ChooseProduct(string chocolateBrand, string chocolateApartheid)
        {
            return null;
        }

        internal override void SpitOutProductOrError(Response response)
        {

        }

        public override string ShowProductList()
        {
            return null;
        }

    }
}
