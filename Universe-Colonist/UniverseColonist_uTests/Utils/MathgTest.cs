using Game.Utils;
using Xunit;

namespace UniverseColonistTests.Utils
{
    public class MathgTest
    {
        [Theory]
        [InlineData(-10, 0, 1, 0)]
        [InlineData(0, 0, 1, 0)]
        [InlineData(0.2, 0, 1, 0.2)]
        [InlineData(10, 0, 1, 1)]
        public void Clamp_ClampedNumber(int value, int min, int max, int expectation)
        {
            // Act
            double result = Mathg.Clamp(value, min, max);

            // Assert
            Assert.Equal(result, expectation);
        }
    }
}