using System;
using System.Collections.Generic;
using System.Text;
using BrusAutomtSimonOgEirik;

namespace BrusAutomatSimonOgEirik
{
    class Storage
    {
        public static List<Product> StorageContainer = new List<Product>();

        public void SendItemToMachines(ChocolateMachine chocolateMachine, DrinksMachine drinksMachine)
        {
            foreach (var product in StorageContainer)
            {
                if (product is Chocolate)
                {
                    chocolateMachine._machineStorage.Add((Chocolate)product);
                }

                if (product is Drink)
                {
                    drinksMachine._machineStorage.Add((Drink)product);
                }
            }
            StorageContainer.Clear();
        }
    }
}
