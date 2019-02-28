using System.Diagnostics;
using Xunit;
using Game.Articles;
using Game.DataModel.Runtime;
using UniverseColonistTests;

namespace Game.GameModel.Tests
{
    public class CashModelTests
    {
        [Theory]
        [InlineData(ResourceType.Stars)]
        [InlineData(ResourceType.HyperMetal)]
        [InlineData(ResourceType.Fuel)]
        [InlineData(ResourceType.Ore)]
        [InlineData(ResourceType.Minerals)]
        [InlineData(ResourceType.Food)]
        [InlineData(ResourceType.Colonist)]
        public void GetCurrentMoney_ExpectedValue(ResourceType currencyType)
        {
            // Arrange
            int expectedValue = 10213300;
            var walletModel = new ResourceModel(TestEnvironment.SetupWalletData(expectedValue));

            // Act
            int money = walletModel.GetCurrentMoney(currencyType);

            // Assert
            Assert.Equal(expectedValue, money);
        }

        [Theory]
        [InlineData(ResourceType.Stars)]
        [InlineData(ResourceType.HyperMetal)]
        [InlineData(ResourceType.Fuel)]
        [InlineData(ResourceType.Ore)]
        [InlineData(ResourceType.Minerals)]
        [InlineData(ResourceType.Food)]
        [InlineData(ResourceType.Colonist)]
        public void AddMoney(ResourceType currencyType)
        {
            // Arrange
            IResourceData cashData = TestEnvironment.SetupWalletData(0);
            var walletModel = new ResourceModel(cashData);

            // Act
            walletModel.AddMoney(currencyType, 1000);
            walletModel.AddMoney(currencyType, 500);

            // Assert
            Assert.Equal(1500, walletModel.GetCurrentMoney(currencyType));
        }

        [Theory]
        [InlineData(ResourceType.Stars, 200, 800)]
        [InlineData(ResourceType.HyperMetal, 500, 500)]
        [InlineData(ResourceType.Fuel, 1000, 0)]
        [InlineData(ResourceType.Ore, 2000, 1000)]
        [InlineData(ResourceType.Minerals, 0, 1000)]
        [InlineData(ResourceType.Food, 100, 900)]
        [InlineData(ResourceType.Colonist, 200, 800)]
        public void DrawMoney_1000Currency_RemainMoney(ResourceType currencyType, int money, int expected)
        {
            // Arrange
            IResourceData cashData = TestEnvironment.SetupWalletData(1000);
            var walletModel = new ResourceModel(cashData);

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
            IResourceData cashData = TestEnvironment.SetupWalletData(1000);
            var walletModel = new ResourceModel(cashData);

            // Act
            bool wasDraw = walletModel.TryDrawMoney(ResourceType.Stars, money);

            // Assert
            Assert.Equal(expected, wasDraw);
        }
    }
}