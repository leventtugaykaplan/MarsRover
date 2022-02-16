using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Implementations;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Test
{
    public class LocatorTest
    {
        private readonly ILocator _locator;

        public LocatorTest()
        {
            IDictionary<Command, ICommandStrategy> commandStrategyDictionary =
                new Dictionary<Command, ICommandStrategy>()
                    {
                        { Command.L, new LeftCommandStrategy() },
                        { Command.R, new RightCommandStrategy() },
                        { Command.M, new MoveCommandStrategy() }
                    };

            _locator = new Locator(commandStrategyDictionary);
        }

        [Fact]
        public void LocateRover_MoveSomewhereInPlateau_UpdateRover()
        {
            Rover rover = new Rover(1, 2, "N");
            Plateau plateau = new Plateau(5, 5);
            string commands = "LMLMLMLMM";
            Rover expected = new Rover(1, 3, "N");

            _locator.LocateRover(rover, plateau, commands);
            
            Assert.True(rover.Equals(expected));
        }

        [Fact]
        public void LocateRover_MoveOutOfPlateau_ThrowsOutOfPlateauException()
        {
            Rover rover = new Rover(1, 2, "N");
            Plateau plateau = new Plateau(5, 5);
            string commands = "RMRMMM";           
            
            Action actual = () => _locator.LocateRover(rover, plateau, commands);

            Assert.Throws<OutOfPlateauException>(actual);
        }

        [Fact]
        public void LocateRover_WrongCommands_ThrowsInvalidCommandException()
        {
            Rover rover = new Rover(1, 2, "N");
            Plateau plateau = new Plateau(5, 5);
            string commands = "X";

            Action actual = () => _locator.LocateRover(rover, plateau, commands);

            Assert.Throws<InvalidCommandException>(actual);
        }
    }
}
