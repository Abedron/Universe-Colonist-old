using Xunit;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Configurations;
using UniverseColonistTests;

namespace Game.Models.Tests
{
    public class WalletModelTests
    {
        [Theory]
        [InlineData(CurrencyType.Stars)]
        [InlineData(CurrencyType.HyperMetal)]
        [InlineData(CurrencyType.Fuel)]
        [InlineData(CurrencyType.Ore)]
        [InlineData(CurrencyType.Minerals)]
        [InlineData(CurrencyType.Food)]
        [InlineData(CurrencyType.Colonist)]
        public void GetCurrencyValue(CurrencyType currencyType)
        {
            // Arrange
            int expectedMoney = 10213300;
            var walletModel = new WalletModel(TestEnvironment.SetupWalletData(expectedMoney));

            // Act
            int money = walletModel.GetCurrentMoney(currencyType);

            // Assert
            Assert.Equal(expectedMoney, money);
        }
    }
}