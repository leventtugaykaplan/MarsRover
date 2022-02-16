using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Implementations;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using MarsRover.Test.SampleDatas;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Test
{
    public class LocatorTest
    {
        private readonly ILocator _locator;
        private readonly IDictionary<Command, ICommandStrategy> _commandStrategyDictionary;
        private readonly Plateau _plateau;

        public LocatorTest()
        {
            _commandStrategyDictionary = new Dictionary<Command, ICommandStrategy>()
                {
                    { Command.L, new LeftCommandStrategy() },
                    { Command.R, new RightCommandStrategy() },
                    { Command.M, new MoveCommandStrategy() }
                };

            _locator = new Locator(_commandStrategyDictionary);
            _plateau = new Plateau(5, 5);
        }

        [Theory]
        [ClassData(typeof(LocatorMoveInPlateauTestDatas))]
        public void LocateRover_MoveSomewhereInPlateau_UpdateRover(Rover rover, string commands, Rover expected)
        {
            _locator.LocateRover(rover, _plateau, commands);

            Assert.True(rover.Equals(expected));
        }

        [Theory]
        [ClassData(typeof(LocatorMoveOutOfPlateauTestDatas))]
        public void LocateRover_MoveOutOfPlateau_ThrowsOutOfPlateauException(Rover rover, string commands)
        {
            Action actual = () => _locator.LocateRover(rover, _plateau, commands);

            Assert.Throws<OutOfPlateauException>(actual);
        }

        [Fact]
        public void LocateRover_WrongCommands_ThrowsInvalidCommandException()
        {
            Rover rover = new Rover(1, 2, "N");
            const string INVALID_COMMAND = "X";

            Action actual = () => _locator.LocateRover(rover, _plateau, INVALID_COMMAND);

            Assert.Throws<InvalidCommandException>(actual);
        }
    }
}
