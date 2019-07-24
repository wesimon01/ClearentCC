using ClearentData;

namespace Clearent
{
    public class MasterCard : CreditCard
    {   
        public MasterCard(CreditCardType cardType, decimal balance) : base(cardType, balance)
        {
            Rate = repo.GetInterestRate(cardType);
        }
    }
}
