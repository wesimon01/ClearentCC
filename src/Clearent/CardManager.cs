﻿using ClearentData;
using System;

namespace Clearent
{
    public static class CardManager
    {
        private static readonly ICreditCardRepo _repo;

        static CardManager()
        {
            _repo = CreditCardRepoFactory.GetRepository();
        }

        public static decimal GetInterestRate(CreditCardType cardType)
        {
            try
            {
                return _repo.GetInterestRate(cardType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
