using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    public class CreditCardFactory
    {
        public static creditCard GetCreditCard(string cardType)
        {
            creditCard cardDetails = null;
            if (cardType == "MoneyBack")
                cardDetails = new MoneyBack();
            if (cardType == "Platinum")
                cardDetails = new Platinum();
            return cardDetails;
        }
    }
   /*public class Program
    {
       public static void Main()
        {
            creditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");
            if(cardDetails!=null)
            {
                Console.WriteLine(cardDetails.cardType());
                Console.WriteLine(cardDetails.cardLimit());
                Console.WriteLine(cardDetails.annualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
        }
    }*/
}
