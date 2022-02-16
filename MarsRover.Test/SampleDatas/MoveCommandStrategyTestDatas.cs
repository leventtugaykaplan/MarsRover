using MarsRover.Entities;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    internal class MoveCommandStrategyTestDatas : TheoryData<Rover, Rover>
    {
        public MoveCommandStrategyTestDatas()
        {
            Add(new Rover(0, 0, "N"), new Rover(0, 1, "N"));
            Add(new Rover(0, 1, "S"), new Rover(0, 0, "S"));
            Add(new Rover(0, 0, "E"), new Rover(1, 0, "E"));
            Add(new Rover(1, 0, "W"), new Rover(0, 0, "W"));
        }
    }
}
