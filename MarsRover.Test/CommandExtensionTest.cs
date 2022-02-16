using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Extensions;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Test
{
    public class CommandExtensionTest
    {
        [Fact]
        public void ConvertToCommandEnum_ValidCommands_ReturnCommandEnumList()
        {
            string commands = "LMLMLMLMM";
            var expected = new List<Command>()
            {
                Command.L,
                Command.M,
                Command.L,
                Command.M,
                Command.L,
                Command.M,
                Command.L,
                Command.M,
                Command.M
            };

            var actual = commands.ConvertToCommandEnum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToCommandEnum_InvalidCommands_Throws()
        {
            string commands = "X";

            Action actual = () => commands.ConvertToCommandEnum();

            Assert.Throws<InvalidCommandException>(actual);
        }
    }
}
