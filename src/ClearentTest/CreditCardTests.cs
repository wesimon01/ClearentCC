using Clearent;
using ClearentData;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class CreditCardTests
    {
        [Test]
        public void TestCase1()
        {
            //Arrange
            var wallets = new List<Wallet>();
            var creditCards = new List<CreditCard>()
            {
                new Visa(CreditCardType.Visa, 100M),
                new MasterCard(CreditCardType.MasterCard, 100M),
                new Discover(CreditCardType.Discover, 100M)
            };
            wallets.Add(new Wallet(creditCards));

            var person = new Person()
            {
                FirstName = "Warren",
                LastName = "Buffet",
                Wallets = wallets
            };
            
            //Act
            var interestPerson = person.CalculateTotalInterest();
            var interestVisa = person.Wallets[0].Cards[0].CalculateInterest();
            var interestMC = person.Wallets[0].Cards[1].CalculateInterest();
            var interestDiscover = person.Wallets[0].Cards[2].CalculateInterest();
            
            //Assert
            Assert.AreEqual(interestPerson, 16M);
            Assert.AreEqual(interestVisa, 10M);
            Assert.AreEqual(interestMC, 5M);
            Assert.AreEqual(interestDiscover, 1M);
        }

        [Test]
        public void TestCase2()
        {
            //Arrange
            var wallets = new List<Wallet>();
            var creditCards1 = new List<CreditCard>()
            {
                new Visa(CreditCardType.Visa, 100M),
                new Discover(CreditCardType.Discover, 100M)
            };
            var creditCards2 = new List<CreditCard>()
            {
                new MasterCard(CreditCardType.MasterCard, 100M)
            };
            wallets.Add(new Wallet(creditCards1));
            wallets.Add(new Wallet(creditCards2));

            var person = new Person()
            {
                FirstName = "Bit",
                LastName = "Coin",
                Wallets = wallets
            };
            
            //Act
            var interestWallet1 = person.Wallets[0].CalculateTotalInterest();
            var interestWallet2 = person.Wallets[1].CalculateTotalInterest();
            var interestPerson = person.CalculateTotalInterest();
            
            //Assert
            Assert.AreEqual(interestWallet1, 11M);
            Assert.AreEqual(interestWallet2, 5M);
            Assert.AreEqual(interestPerson, 16M);
        }

        [Test]
        public void TestCase3()
        {
            //Arrange
            var wallets1 = new List<Wallet>();
            wallets1.Add(new Wallet(
                new List<CreditCard>()
                {
                    new MasterCard(CreditCardType.MasterCard, 100M),
                    new MasterCard(CreditCardType.MasterCard, 100M),
                    new Visa(CreditCardType.Visa, 100M)
                }                
            ));

            var person1 = new Person()
            {
                FirstName = "Warren",
                LastName = "Buffet",
                Wallets = wallets1
            };
            
            var wallets2 = new List<Wallet>();
            wallets2.Add(new Wallet(
                new List<CreditCard>()
                {
                    new Visa(CreditCardType.Visa, 100M),
                    new MasterCard(CreditCardType.MasterCard, 100M)
                }                
            ));
            
            var person2 = new Person()
            {
                FirstName = "Bit",
                LastName = "Coin",
                Wallets = wallets2
            };

            //Act
            var interestPerson1 = person1.CalculateTotalInterest();
            var interestPerson2 = person2.CalculateTotalInterest();
            var interestWallet1Person1 = person1.Wallets[0].CalculateTotalInterest();
            var interestWallet1Person2 = person2.Wallets[0].CalculateTotalInterest();

            //Assert
            Assert.AreEqual(interestPerson1, 20M);
            Assert.AreEqual(interestPerson2, 15M);
            Assert.AreEqual(interestWallet1Person1, 20M);
            Assert.AreEqual(interestWallet1Person2, 15M);
        }
    }
}