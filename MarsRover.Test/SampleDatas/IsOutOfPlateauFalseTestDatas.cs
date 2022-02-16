using MarsRover.Entities;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    public class IsOutOfPlateauFalseTestDatas : TheoryData<Rover>
    {
        public IsOutOfPlateauFalseTestDatas()
        {
            Add(new Rover(1, 5, "N"));
            Add(new Rover(1, 0, "S"));
            Add(new Rover(0, 1, "W"));
            Add(new Rover(5, 1, "E"));
        }
    }
}
