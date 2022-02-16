using MarsRover.Entities;
using MarsRover.Extensions;
using MarsRover.Test.SampleDatas;
using Xunit;

namespace MarsRover.Test
{
    public class RoverExtensionTest
    {
        private readonly Plateau _plateau;

        public RoverExtensionTest()
        {
            _plateau = new Plateau(5, 5);
        }

        [Theory]
        [ClassData(typeof(IsOutOfPlateauFalseTestDatas))]
        public void IsOutOfPlateau_RoverInPlateau_ReturnFalse(Rover rover)
        {
            bool actual = rover.IsOutOfPlateau(_plateau);

            Assert.False(actual);
        }

        [Theory]
        [ClassData(typeof(IsOutOfPlateauTrueTestDatas))]
        public void IsOutOfPlateau_RoverOutOfPlateau_ReturnTrue(Rover rover)
        {
            bool actual = rover.IsOutOfPlateau(_plateau);

            Assert.True(actual);
        }
    }
}
