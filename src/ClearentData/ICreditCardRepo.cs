using System.Collections.Generic;

namespace ClearentData
{
    public interface ICreditCardRepo
    {
        decimal GetInterestRate(CreditCardType cardType);
        Dictionary<CreditCardType, decimal> GetCardRates();
    }
}
