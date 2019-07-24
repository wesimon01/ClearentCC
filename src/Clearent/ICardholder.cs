using System.Collections.Generic;

namespace Clearent
{
    public interface ICardholder
    {
        List<Wallet> Wallets { get; set; }
        decimal CalculateTotalInterest();
    }
}