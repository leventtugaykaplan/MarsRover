using MarsRover.Entities;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    public class IsOutOfPlateauTrueTestDatas : TheoryData<Rover>
    {
        public IsOutOfPlateauTrueTestDatas()
        {
            Add(new Rover(6, 0, "N"));
            Add(new Rover(-1, 0, "S"));
            Add(new Rover(0, 6, "W"));
            Add(new Rover(0, -1, "E"));
        }
    }
}
