using System.Diagnostics;
using Xunit;
using Game.Items;
using Game.DataModel.Runtime;
using UniverseColonistTests;

namespace Game.GameModels.Tests
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
        public void GetCurrentMoney_ExpectedValue(CurrencyType currencyType)
        {
            // Arrange
            int expectedValue = 10213300;
            var walletModel = new CasheModel(TestEnvironment.SetupWalletData(expectedValue));

            // Act
            int money = walletModel.GetCurrentMoney(currencyType);

            // Assert
            Assert.Equal(expectedValue, money);
        }

        [Theory]
        [InlineData(CurrencyType.Stars)]
        [InlineData(CurrencyType.HyperMetal)]
        [InlineData(CurrencyType.Fuel)]
        [InlineData(CurrencyType.Ore)]
        [InlineData(CurrencyType.Minerals)]
        [InlineData(CurrencyType.Food)]
        [InlineData(CurrencyType.Colonist)]
        public void AddMoney(CurrencyType currencyType)
        {
            // Arrange
            IWallet wallet = TestEnvironment.SetupWalletData(0);
            var walletModel = new CasheModel(wallet);

            // Act
            walletModel.AddMoney(currencyType, 1000);
            walletModel.AddMoney(currencyType, 500);

            // Assert
            Assert.Equal(1500, walletModel.GetCurrentMoney(currencyType));
        }

        [Theory]
        [InlineData(CurrencyType.Stars, 200, 800)]
        [InlineData(CurrencyType.HyperMetal, 500, 500)]
        [InlineData(CurrencyType.Fuel, 1000, 0)]
        [InlineData(CurrencyType.Ore, 2000, 1000)]
        [InlineData(CurrencyType.Minerals, 0, 1000)]
        [InlineData(CurrencyType.Food, 100, 900)]
        [InlineData(CurrencyType.Colonist, 200, 800)]
        public void DrawMoney_1000Currency_RemainMoney(CurrencyType currencyType, int money, int expected)
        {
            // Arrange
            IWallet wallet = TestEnvironment.SetupWalletData(1000);
            var walletModel = new CasheModel(wallet);

            // Act
            walletModel.TryDrawMoney(currencyType, money);

            // Assert
            Assert.Equal(expected, walletModel.GetCurrentMoney(currencyType));
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(483, true)]
        [InlineData(999, true)]
        [InlineData(0, false)]
        [InlineData(1001, false)]
        [InlineData(int.MaxValue, false)]
        public void DrawMoney_1000Currency_WasDraw(int money, bool expected)
        {
            // Arrange
            IWallet wallet = TestEnvironment.SetupWalletData(1000);
            var walletModel = new CasheModel(wallet);

            // Act
            bool wasDraw = walletModel.TryDrawMoney(CurrencyType.Stars, money);

            // Assert
            Assert.Equal(expected, wasDraw);
        }
    }
}