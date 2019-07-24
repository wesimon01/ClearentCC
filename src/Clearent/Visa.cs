using ClearentData;

namespace Clearent
{
    public class Visa : CreditCard
    {       
        public Visa(CreditCardType cardType, decimal balance) : base(cardType, balance)
        {
            Rate = repo.GetInterestRate(cardType);
        }
    }
}
