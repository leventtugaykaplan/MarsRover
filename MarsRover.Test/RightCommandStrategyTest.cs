using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using MarsRover.Test.SampleDatas;
using Xunit;

namespace MarsRover.Test
{
    public class RightCommandStrategyTest
    {
        private readonly ICommandStrategy _strategy;

        public RightCommandStrategyTest()
        {
            _strategy = new RightCommandStrategy();
        }

        [Theory]
        [ClassData(typeof(RightCommandStrategyTestDatas))]
        public void RunCommand_RoverTurnRight_ReturnRoverOrientationTurnedRight(Rover rover, CompassCardinalPoint expected)
        {
            _strategy.RunCommand(rover);

            Assert.Equal(expected, rover.Orientation);
        }
    }
}
