using ClearentData;

namespace Clearent
{
    public class Visa : CreditCard
    {   
        public Visa(decimal balance) : base(balance)
        {
            cardType = CreditCardType.Visa;
            Rate = CardManager.GetInterestRate(cardType);
        }
    }
}
