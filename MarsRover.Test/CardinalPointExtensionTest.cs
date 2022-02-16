using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Extensions;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class CardinalPointExtensionTest
    {
        [Theory]
        [InlineData("N", CompassCardinalPoint.N)]
        [InlineData("W", CompassCardinalPoint.W)]
        [InlineData("S", CompassCardinalPoint.S)]
        [InlineData("E", CompassCardinalPoint.E)]
        public void ConvertToCardinalPointEnum_ValidCardinalPointString_ReturnCardinalPointEnum(string command, CompassCardinalPoint expected)
        {
            var actual = command.ConvertToCardinalPointEnum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToCardinalPointEnum_InvalidCommands_ThrowsInvalidCardinalPointException()
        {
            const string INVALID_CARDINAL_POINT = "X";

            Action actual = () => INVALID_CARDINAL_POINT.ConvertToCardinalPointEnum();

            Assert.Throws<InvalidCardinalPointException>(actual);
        }
    }
}
