using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class DrinksMachine : VendingMachine
    {
        public List<Product> _machineStorage = new List<Product>();

        public override Product ChooseSoda(string sodaName)
        {
            Product chosenSoda = _machineStorage.FirstOrDefault(S => S.Name == sodaName);
            if (CheckSuccessfullProduct(chosenSoda).IsSuccess)
            {
                return chosenSoda;
            }
            return null;
        }
        internal override Product SpitOutProduct(Product chosenSoda)
        {
            chosenSoda.Storage--;
            Console.WriteLine($"A {chosenSoda.Name} was dropped to the bottom tray");
            return null;
        }
        private Response CheckSuccessfullProduct(Product chosenSoda)
        {
            if (Balance < chosenSoda.Price)
            {
                return new Response(false, "you need to put in more monay");
            }
            if (chosenSoda != null)
            {
                return new Response(false, $"{sodaName} is not valid name");
            }
            if (chosenSoda.Storage > 0)
            {
                return new Response(false, $"The machine is out of that soda");
            }
        }

        public override string ShowProductList()
        {
            string ProductsString = string.Empty;
            foreach (var product in _machineStorage) ProductsString.Concat(product.Name + " ");
            return ProductsString;
        } 
    }
}
