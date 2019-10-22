using ClearentData;

namespace Clearent
{
    public class Discover : CreditCard
    {                      
        public Discover(decimal balance) : base(balance)
        {
            cardType = CreditCardType.Discover;
            Rate = CardManager.GetInterestRate(cardType);
        }       
    }
}
