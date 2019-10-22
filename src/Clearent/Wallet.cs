using System.Collections.Generic;

namespace Clearent
{
    public class Wallet
    {
        public List<CreditCard> Cards { get; set; } = new List<CreditCard>();

        public Wallet() { }
        
        public Wallet(List<CreditCard> cards)
        {
            Cards = cards;
        }

        public decimal CalculateWalletInterest()
        {
            decimal result = 0M;                        
            
            foreach(CreditCard c in Cards)
            {
                result += c.CalculateCardInterest();
            }                        
            return result;
        }
    }
}
