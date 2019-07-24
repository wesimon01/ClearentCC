using System;
using System.Collections.Generic;

namespace ClearentData
{
    public class CreditCardTestRepo : ICreditCardRepo
    {
        public static Dictionary<CreditCardType, decimal> CardRates = new Dictionary<CreditCardType, decimal>
        {            
            { CreditCardType.Visa, 0.1M },
            { CreditCardType.MasterCard, 0.05M },
            { CreditCardType.Discover, 0.01M }
        }; 

        public decimal GetInterestRate(CreditCardType cardType)
        {
            if (CardRates.ContainsKey(cardType))
                return CardRates[cardType];
            else
                throw new Exception($"!Error!, Could not find interest rate for {cardType.ToString()}");
        }
    }
}
