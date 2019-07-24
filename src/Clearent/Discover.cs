using ClearentData;

namespace Clearent
{
    public class Discover : CreditCard
    {               
        public Discover(CreditCardType cardType, decimal balance) : base(cardType, balance)
        {
            Rate = repo.GetInterestRate(cardType);
        }       
    }
}
