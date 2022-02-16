using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Extensions;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class CardinalPointExtensionTest
    {
        [Fact]
        public void ConvertToCardinalPointEnum_ValidCardinalPointString_ReturnCardinalPointEnum()
        {
            string commands = "N";
            var expected = CompassCardinalPoint.N;

            var actual = commands.ConvertToCardinalPointEnum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToCardinalPointEnum_InvalidCommands_ThrowsInvalidCardinalPointException()
        {
            string commands = "X";

            Action actual = () => commands.ConvertToCardinalPointEnum();

            Assert.Throws<InvalidCardinalPointException>(actual);
        }
    }
}
