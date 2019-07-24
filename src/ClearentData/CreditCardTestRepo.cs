using System;
using System.Collections.Generic;

namespace ClearentData
{
    public class CreditCardTestRepo : ICreditCardRepo
    {
        private static Dictionary<CreditCardType, decimal> _cardRates;

        public CreditCardTestRepo() 
        {           
            if (_cardRates == null)
            {
                _cardRates = new Dictionary<CreditCardType, decimal>
                {
                    { CreditCardType.Visa, 0.1M },
                    { CreditCardType.MasterCard, 0.05M },
                    { CreditCardType.Discover, 0.01M }
                }; 
            }            
        }        
        public Dictionary<CreditCardType, decimal> GetCardRates()
        {
            return _cardRates;
        }
        public decimal GetInterestRate(CreditCardType cardType)
        {
            var rates = GetCardRates();
            if (rates.ContainsKey(cardType))
                return rates[cardType];
            else
                throw new Exception($"!Error!, Could not find interest rate for {cardType.ToString()}");
        }
    }
}
