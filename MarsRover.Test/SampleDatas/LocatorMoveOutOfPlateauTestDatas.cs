using MarsRover.Entities;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    public class LocatorMoveOutOfPlateauTestDatas : TheoryData<Rover, string>
    {
        public LocatorMoveOutOfPlateauTestDatas()
        {
            Add(new Rover(1, 5, "N"), "M");
            Add(new Rover(1, 0, "S"), "M");
            Add(new Rover(0, 1, "W"), "M");
            Add(new Rover(5, 1, "E"), "M");
        }
    }
}
