using ClearentData;

namespace Clearent
{
    public abstract class CreditCard
    {   
        public decimal Balance { get; set; }
        public decimal Rate { get; set; }
        
        protected CreditCardType cardType;

        public CreditCard(decimal balance)
        {
            Balance = balance;
        }
        
        public virtual decimal CalculateCardInterest() => Rate * Balance;
        
    }
}
