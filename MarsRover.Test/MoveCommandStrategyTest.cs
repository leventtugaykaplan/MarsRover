using MarsRover.Entities;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
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

        [Fact]
        public void RunCommand_MoveRoverInXAxis_ReturnOneUnitForwardInXAxis()
        {
            Rover rover = new Rover(0, 0, "N");

            _strategy.RunCommand(rover);

            Assert.Equal(1, rover.Coordination.Y);
        }

        [Fact]
        public void RunCommand_MoveRoverInXAxis_ReturnOneUnitBackInXAxis()
        {
            Rover rover = new Rover(0, 1, "S");

            _strategy.RunCommand(rover);

            Assert.Equal(0, rover.Coordination.Y);
        }

        [Fact]
        public void RunCommand_MoveRoverInYAxis_ReturnOneUnitForwardInYAxis()
        {
            Rover rover = new Rover(0, 0, "E");

            _strategy.RunCommand(rover);

            Assert.Equal(1, rover.Coordination.X);
        }

        [Fact]
        public void RunCommand_MoveRoverInYAxis_ReturnOneUnitBackInYAxis()
        {
            Rover rover = new Rover(1, 0, "W");

            _strategy.RunCommand(rover);

            Assert.Equal(0, rover.Coordination.X);
        }
    }
}
