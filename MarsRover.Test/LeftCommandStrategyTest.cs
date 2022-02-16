using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using MarsRover.Test.SampleDatas;
using Xunit;

namespace MarsRover.Test
{
    public class LeftCommandStrategyTest
    {
        private readonly ICommandStrategy _strategy;

        public LeftCommandStrategyTest()
        {
            _strategy = new LeftCommandStrategy();
        }

        [Theory]
        [ClassData(typeof(LeftCommandStrategyTestDatas))]
        public void RunCommand_RoverOrientationNorthTurnLeft_ReturnRoverOrientationTurnedLeft(Rover rover, CompassCardinalPoint expected)
        {
            _strategy.RunCommand(rover);

            Assert.Equal(expected, rover.Orientation);
        }
    }
}
