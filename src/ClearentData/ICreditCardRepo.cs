using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentData
{
    public interface ICreditCardRepo
    {
        decimal GetInterestRate(CreditCardType cardType);
    }
}
