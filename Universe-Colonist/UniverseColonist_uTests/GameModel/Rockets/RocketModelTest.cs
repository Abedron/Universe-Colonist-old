﻿using Xunit;
using System;
using Game.Articles;
using Game.GameModel;

namespace UniverseColonistTests.GameModel
{
    public class RocketModelTest
    {
        [Fact]
        public void TrySendTo_SetupRocketData()
        {
            // Arrange
            var rocket = new RocketModel(TestEnvironment.NeoVRocketData);
            var startTime = new DateTime();
            var endTime = startTime.AddSeconds(TestEnvironment.MercuryPlanetData.Definition.JourneyTime);

            // Act
            bool expected = rocket.TrySendTo(TestEnvironment.MercuryPlanetData, startTime);

            // Assert
            Assert.True(expected);
            Assert.Equal(PlanetType.Mercury, rocket.Data.PlanetTarget);
            Assert.Equal(startTime, rocket.Data.StartTime);
            Assert.Equal(endTime, rocket.Data.EndTime);
        }

        [Fact]
        public void BoostFinish_SetupToDefaultRocketData()
        {
            // Arrange
            var rocket = new RocketModel(TestEnvironment.NeoVRocketData);
            var startTime = new DateTime();

            rocket.TrySendTo(TestEnvironment.MercuryPlanetData, startTime);

            // Act
            rocket.BoostFinish(startTime);

            // Assert
            Assert.Equal(PlanetType.None, rocket.Data.PlanetTarget);
            Assert.Equal(startTime, rocket.Data.StartTime);
            Assert.Equal(startTime, rocket.Data.EndTime);
        }
    }
}
