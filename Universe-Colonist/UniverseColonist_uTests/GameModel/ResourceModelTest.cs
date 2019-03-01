using System.Diagnostics;
using Xunit;
using Game.Articles;
using Game.DataModel.Runtime;
using UniverseColonistTests;

namespace Game.GameModel.Tests
{
    public class ResourceModelTest
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
            var resourceModel = new ResourceModel(TestEnvironment.SetupResourceDataData(expectedValue));

            // Act
            int money = resourceModel.GetCurrentMoney(currencyType);

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
            IResourceData resourceData = TestEnvironment.SetupResourceDataData(0);
            var resourceModel = new ResourceModel(resourceData);

            // Act
            resourceModel.AddMoney(currencyType, 1000);
            resourceModel.AddMoney(currencyType, 500);

            // Assert
            Assert.Equal(1500, resourceModel.GetCurrentMoney(currencyType));
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
            IResourceData resourceData = TestEnvironment.SetupResourceDataData(1000);
            var resourceModel = new ResourceModel(resourceData);

            // Act
            resourceModel.TryDrawMoney(currencyType, money);

            // Assert
            Assert.Equal(expected, resourceModel.GetCurrentMoney(currencyType));
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
            IResourceData resourceData = TestEnvironment.SetupResourceDataData(1000);
            var resourceModel = new ResourceModel(resourceData);

            // Act
            bool wasDraw = resourceModel.TryDrawMoney(ResourceType.Stars, money);

            // Assert
            Assert.Equal(expected, wasDraw);
        }
    }
}