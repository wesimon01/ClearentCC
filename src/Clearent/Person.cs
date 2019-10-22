using System.Collections.Generic;

namespace Clearent
{
    public class Person : ICardholder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Wallet> Wallets { get; set; } = new List<Wallet>();
        
        public Person() { }

        public Person(List<Wallet> wallets)
        {
            Wallets = wallets;
        }

        public decimal CalculateTotalInterest()
        {
            decimal result = 0M;
            
            foreach(Wallet w in Wallets)
            {
                result += w.CalculateWalletInterest();
            }
            return result;
        }
    }
}
