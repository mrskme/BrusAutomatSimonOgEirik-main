using System;
using System.Collections.Generic;
using System.Text;
using BrusAutomatSimonOgEirik;

namespace BrusAutomtSimonOgEirik
{
    class ChocolateMachine : VendingMachine
    {
        public List<Product> _machineStorage = new List<Product>();
        public override Product ChooseSoda(string input)
        {
            return null;
        }

        internal override void SpitOutProduct(Product chosenChocolate)
        {
            
        }

        public override string ShowProductList()
        {
            return null;
        }

    }
}
