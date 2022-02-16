using MarsRover.Entities;
using MarsRover.Enums;
using Xunit;

namespace MarsRover.Test.SampleDatas
{
    internal class LeftCommandStrategyTestDatas : TheoryData<Rover, CompassCardinalPoint>
    {
        public LeftCommandStrategyTestDatas()
        {
            Add(new Rover(0, 0, "N"), CompassCardinalPoint.W);
            Add(new Rover(0, 0, "W"), CompassCardinalPoint.S);
            Add(new Rover(0, 0, "S"), CompassCardinalPoint.E);
            Add(new Rover(0, 0, "E"), CompassCardinalPoint.N);
        }
    }
}
