using MarsRover.Entities;
using MarsRover.Extensions;
using Xunit;

namespace MarsRover.Test
{
    public class RoverExtensionTest
    {
        [Fact]
        public void IsOutOfPlateau_RoverOutOfPlateau_ReturnTrue()
        {
            Rover rover = new Rover(1, 2, "N");
            Plateau plateau = new Plateau(5, 5);

            bool actual = rover.IsOutOfPlateau(plateau);

            Assert.False(actual);
        }

        [Fact]
        public void IsOutOfPlateau_RoverInPlateau_ReturnFalse()
        {
            Rover rover = new Rover(6, 5, "N");
            Plateau plateau = new Plateau(5, 5);

            bool actual = rover.IsOutOfPlateau(plateau);

            Assert.True(actual);
        }
    }
}
