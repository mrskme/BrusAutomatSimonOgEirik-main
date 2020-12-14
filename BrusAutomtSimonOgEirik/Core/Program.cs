using System;
using BrusAutomtSimonOgEirik;

namespace BrusAutomatSimonOgEirik
{
    class Program /*: VendingMachine*/
    {
        static void Main(string[] args)
        {
            //Implementer en brusautomat. Ulike drikker har ulik pris. Automaten har en lagerbeholdning.
            //Man kan putte på mynter (1kr, 5kr, 10kr, 20kr). Man trykker på en knapp for en bestemt drikk
            //- hvis man har puttet på nok får man denne og saldoen reduseres tilsvarende.
            //Det finnes en knapp for å få gjeldende saldo tilbake. 
            //en fabrikk som lager brusen
            //En storage som lagrer brus og er mellomledd mellom factory og vending machine
            //abstrakt method and override
            //SjokoladeMachine

            //spørsmål til terje: Er det best å sende Factory til storage eller å gette fra storage 

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
            drinksMachine.InsertCoins(10);
            drinksMachine.CheckBalance();

            var chosenSoda = drinksMachine.ChooseSoda("Coca Cola");
            drinksMachine.DeductPrice(chosenSoda.Price);
            drinksMachine.SpitOutProduct(chosenSoda);
            drinksMachine.ShowProductList();

            drinksMachine.ReturnCoins();

            //ChocolateMachine
            //chocolateMachine.InsertCoins(20);
            //chocolateMachine.CheckBalance();

            //var chosenChocolate = chocolateMachine.chooseChocolate("White Lion");
            //chocolateMachine.DeductPrice(chosenChocolate.Price);
            //chocolateMachine.SpitOutProduct(chosenChocolate);

            //chocolateMachine.ReturnCoins();

        }
    }
}
