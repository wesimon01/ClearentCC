using Clearent;
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
            var person = new Person()
            {
                FirstName = "Warren",
                LastName = "Buffet",
            };
            var creditCards = new List<CreditCard>()
            {
                new Visa(100M),
                new MasterCard(100M),
                new Discover(100M)
            };
            person.Wallets.Add(new Wallet(creditCards));
          
            //Act
            var interestPerson = person.CalculateTotalInterest();
            var interestVisa = person.Wallets[0].Cards[0].CalculateCardInterest();
            var interestMC = person.Wallets[0].Cards[1].CalculateCardInterest();
            var interestDiscover = person.Wallets[0].Cards[2].CalculateCardInterest();
            
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
            var person = new Person()
            {
                FirstName = "Bit",
                LastName = "Coin",
            };
            var creditCards1 = new List<CreditCard>()
            {
                new Visa(100M),
                new Discover(100M)
            };
            var creditCards2 = new List<CreditCard>()
            {
                new MasterCard(100M)
            };
            person.Wallets.Add(new Wallet(creditCards1));
            person.Wallets.Add(new Wallet(creditCards2));

            
            //Act
            var interestWallet1 = person.Wallets[0].CalculateWalletInterest();
            var interestWallet2 = person.Wallets[1].CalculateWalletInterest();
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
            var person1 = new Person()
            {
                FirstName = "Warren",
                LastName = "Buffet",
            };            
            person1.Wallets.Add(new Wallet(
                new List<CreditCard>()
                {
                    new Visa(100M),
                    new MasterCard(100M),
                    new Discover(100M)
                }                
            ));
            
            var person2 = new Person()
            {
                FirstName = "Bit",
                LastName = "Coin",
            };
            person2.Wallets.Add(new Wallet(
                new List<CreditCard>()
                {
                    new Visa(100M),
                    new MasterCard(100M)
                }                
            ));

            //Act
            var interestPerson1 = person1.CalculateTotalInterest();
            var interestPerson2 = person2.CalculateTotalInterest();
            var interestWallet1Person1 = person1.Wallets[0].CalculateWalletInterest();
            var interestWallet1Person2 = person2.Wallets[0].CalculateWalletInterest();

            //Assert
            Assert.AreEqual(interestPerson1, 16M);
            Assert.AreEqual(interestPerson2, 15M);
            Assert.AreEqual(interestWallet1Person1, 16M);
            Assert.AreEqual(interestWallet1Person2, 15M);
        }
    }
}