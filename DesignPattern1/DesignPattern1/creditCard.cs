using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    public interface creditCard
    {
       public string cardType();
       public int cardLimit();
       public  int annualCharge();

    }
   public class MoneyBack:creditCard
    {
       public  string cardType()
        {
            return "MoneyBack";
        }
        public int cardLimit()
        {
            return 15000;
        }
        public int annualCharge()
        {
            return 500;
        }
    }
   public  class Platinum : creditCard
    {
        public string cardType()
        {
            return "Platinum plus ";
        }
        public int cardLimit()
        {
            return 50000;
        }
        public int annualCharge()
        {
            return 900;
        }
    }
   
}
