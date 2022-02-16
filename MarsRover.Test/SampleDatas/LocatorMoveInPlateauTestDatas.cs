using MarsRover.Entities;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    public class LocatorMoveInPlateauTestDatas : TheoryData<Rover, string, Rover>
    {
        public LocatorMoveInPlateauTestDatas()
        {
            Add(new Rover(1, 2, "N"), "LMLMLMLMM", new Rover(1, 3, "N"));
            Add(new Rover(3, 3, "E"), "MMRMMRMRRM", new Rover(5, 1, "E"));
        }
    }
}
