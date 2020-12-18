using System;
using BrusAutomtSimonOgEirik;

namespace BrusAutomatSimonOgEirik
{
    class Program /*: VendingMachine*/
    {
        static void Main(string[] args)
        { 
            var drinksFactory = new DrinksFactory();
            var chocolateFactory = new ChocolateFactory();

            var drinksMachine = new DrinksMachine();
            var chocolateMachine = new ChocolateMachine();
            var storage = new Storage();

            //Factory
            drinksFactory.SendProductToStorage(drinksFactory.MakeProducts());
            chocolateFactory.SendProductToStorage(chocolateFactory.MakeProducts());

            //Storage
            storage.SendItemToMachines(chocolateMachine, drinksMachine);

            //DrinksMachine
            drinksMachine.InsertCoins(500);
            drinksMachine.CheckBalance();

            Console.WriteLine(drinksMachine.ShowProductList());

            var response = drinksMachine.ChooseProduct("Urge Intense", "Plastic");

            drinksMachine.SpitOutProductOrError(response);
            drinksMachine.ReturnCoins();

            Console.WriteLine(drinksMachine.ShowProductList());

            //ChocolateMachine
            //chocolateMachine.InsertCoins(20);
            //chocolateMachine.CheckBalance();

            //var chosenChocolate = chocolateMachine.chooseChocolate("White Lion");
            //chocolateMachine.DeductPrice(chosenChocolate.Price);
            //chocolateMachine.SpitOutProductOrError(chosenChocolate);

            //chocolateMachine.ReturnCoins();

        }
    }
}
