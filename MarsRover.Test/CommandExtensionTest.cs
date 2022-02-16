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
            string commands = "LMR";
            var expected = new List<Command>()
            {
                Command.L,
                Command.M,
                Command.R,
            };

            var actual = commands.ConvertToCommandEnum();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToCommandEnum_InvalidCommandsThrowsInvalidCommandException()
        {
            const string INVALID_COMMAND = "X";

            Action actual = () => INVALID_COMMAND.ConvertToCommandEnum();

            Assert.Throws<InvalidCommandException>(actual);
        }
    }
}
