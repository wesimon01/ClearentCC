using ClearentData;

namespace Clearent
{
    public abstract class CreditCard
    {       
        public decimal Balance { get; set; }
        public decimal Rate { get; set; }
        public CreditCardType CardType { get; set; }

        protected ICreditCardRepo repo;

        public CreditCard(CreditCardType cardType, decimal balance)
        {
            repo = CreditCardRepoFactory.GetRepository();
            CardType = cardType;
            Balance = balance;
        }
        
        public decimal CalculateInterest()
            => Rate * Balance;
    }
}
