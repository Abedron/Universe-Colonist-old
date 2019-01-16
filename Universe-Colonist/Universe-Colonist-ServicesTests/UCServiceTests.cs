using Xunit;
using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services.Tests
{
    public class UCServiceTests
    {
        [Fact()]
        public void Load_ProgressDefinition()
        {
            // Arrange
            var service = new UCService();

            // Act
            string text = service.Load("https://raw.githubusercontent.com/codepath/android_guides/master/LICENSE.md");

            // Assert
            Assert.NotNull(text);
        }
    }
}