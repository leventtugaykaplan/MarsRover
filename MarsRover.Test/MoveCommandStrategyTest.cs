using MarsRover.Entities;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using MarsRover.Test.SampleDatas;
using Xunit;

namespace MarsRover.Test
{
    public class MoveCommandStrategyTest
    {
        private readonly ICommandStrategy _strategy;

        public MoveCommandStrategyTest()
        {
            _strategy = new MoveCommandStrategy();
        }

        [Theory]
        [ClassData(typeof(MoveCommandStrategyTestDatas))]
        public void RunCommand_MoveRover_ReturnRoverOneUnitForward(Rover rover, Rover expected)
        {
            _strategy.RunCommand(rover);

            Assert.Equal(expected, rover);
        }
    }
}
