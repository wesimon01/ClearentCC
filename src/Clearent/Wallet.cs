using System.Collections.Generic;

namespace Clearent
{
    public class Wallet
    {
        public List<CreditCard> Cards { get; set; }

        public Wallet()
        {
            Cards = new List<CreditCard>();
        }       
        public Wallet(List<CreditCard> cards)
        {
            Cards = cards;
        }
        public decimal CalculateTotalInterest()
        {
            decimal result = 0M;                        
            
            foreach(CreditCard c in Cards)            
                result += c.CalculateInterest();
            
            return result;
        }
    }
}
