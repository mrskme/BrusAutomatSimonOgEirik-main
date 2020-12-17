using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class DrinksMachine : VendingMachine
    {
        public List<Drink> _machineStorage = new List<Drink>();

        public override Response ChooseProduct(string sodaName, string sodaMaterial)
        {
            Drink chosenSoda = _machineStorage.FirstOrDefault(S => S.Name == sodaName && S.Material == sodaMaterial);
            return CheckSuccessfullProduct(chosenSoda);
        }
        internal override void SpitOutProductOrError(Response response)
        {
            Console.WriteLine(response.Message);
            if(response.IsSuccess) PlayJingle();
        }
        private Response CheckSuccessfullProduct(Drink chosenSoda)
        {
            if (chosenSoda == null)
            {
                return new Response($"404 Error. Instructions not clear, dick stuck in blender. (Name or material is invalid)", false);
            }
            if (0 > chosenSoda.Storage)
            {
                return new Response($"The machine is out of that soda", false);
            }
            if (Balance < chosenSoda.Price)
            {
                return new Response( "you need to put in more monay", false);
            }
            chosenSoda.Storage--;
            DeductPrice(chosenSoda.Price);
            return new Response($"Thank you for your for chosing to use Vending Machines Inc.\nPlease wait for the machine to calculate your remaining money\nAs a trusted customer we here at Vending Machines Inc value your existence\nHere is your 100% guaranteed to be refreshing {chosenSoda.Size}MLs {chosenSoda.Material} {chosenSoda.Name} beverage\n", true);
        }
        
        public override string ShowProductList()
        {
            StringBuilder concatenatedString = new StringBuilder();
            concatenatedString.Append("Product List:\n\n");
            foreach (var productBreed in _machineStorage) concatenatedString.Append($" {productBreed.Size}MLs - {productBreed.Material} -  {productBreed.Name} - {productBreed.Storage} left - {productBreed.Price} NOK\n");
            return concatenatedString.ToString();
        }

        public void PlayJingle()
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }
    }
}
