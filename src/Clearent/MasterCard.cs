using ClearentData;

namespace Clearent
{
    public class MasterCard : CreditCard
    {   
        public MasterCard(decimal balance) : base(balance)
        {
            cardType = CreditCardType.MasterCard;
            Rate = CardManager.GetInterestRate(cardType);
        }
    }
}
