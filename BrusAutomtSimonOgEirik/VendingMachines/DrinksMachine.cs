using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class DrinksMachine : VendingMachine
    {
        public List<Drink> _machineStorage = new List<Drink>();

        public override Response ChooseSoda(string sodaName)
        {
            Drink chosenSoda = _machineStorage.FirstOrDefault(S => S.Name == sodaName);
            return CheckSuccessfullProduct(chosenSoda, sodaName);
        }
        internal override void SpitOutProductOrError(Response response)
        {
            Console.WriteLine(response.Message);
        }
        private Response CheckSuccessfullProduct(Product chosenSoda, string sodaName)
        {
            if (chosenSoda == null)
            {
                return new Response($"{sodaName} is not valid name", false);
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
            return new Response($"Error 404, Instructions not clear, dick stuck in blender. bare tulla det funka her er din {chosenSoda.Name}", true);
        }

        public override string ShowProductList()
        {
            StringBuilder concatenatedString = new StringBuilder();
            concatenatedString.Append("Product List:\n\n");
            foreach (var productBreed in _machineStorage) concatenatedString.Append($" {productBreed.Size}MLs - {productBreed.Material} -  {productBreed.Name} - {productBreed.Storage} left - {productBreed.Price} NOK\n");
            return concatenatedString.ToString();
        } 
    }
}
