using MarsRover.Entities;
using MarsRover.Enums;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    internal class RightCommandStrategyTestDatas : TheoryData<Rover, CompassCardinalPoint>
    {
        public RightCommandStrategyTestDatas()
        {
            Add(new Rover(0, 0, "N"), CompassCardinalPoint.E);
            Add(new Rover(0, 0, "E"), CompassCardinalPoint.S);
            Add(new Rover(0, 0, "S"), CompassCardinalPoint.W);
            Add(new Rover(0, 0, "W"), CompassCardinalPoint.N);
        }
    }
}
