using Xunit;
using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services.Tests
{
    public class UCLocalServiceTests
    {
        [Fact]
        public void Load_ProgressDefinition()
        {
            // Arrange
            var service = new UCLocalService();

            // Act
            string text = service.Load("Data/Definitions/Progress.json");

            // Assert
            Assert.NotNull(text);
        }
    }
}