﻿using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using Xunit;

namespace MarsRover.Test
{
    public class LeftCommandStrategyTest
    {
        private readonly ICommandStrategy _strategy;

        public LeftCommandStrategyTest()
        {
            _strategy = new LeftCommandStrategy();
        }

        [Fact]
        public void RunCommand_RoverOrientationNorthTurnLeft_ReturnRoverOrientationWest()
        {
            Rover rover = new Rover(1, 2, "N");

            _strategy.RunCommand(rover);

            Assert.Equal(CompassCardinalPoint.W, rover.Orientation);
        }

        [Fact]
        public void RunCommand_RoverOrientationWestTurnLeft_ReturnRoverOrientationSouth()
        {
            Rover rover = new Rover(1, 2, "W");

            _strategy.RunCommand(rover);

            Assert.Equal(CompassCardinalPoint.S, rover.Orientation);
        }

        [Fact]
        public void RunCommand_RoverOrientationSouthTurnLeft_ReturnRoverOrientationEast()
        {
            Rover rover = new Rover(1, 2, "S");

            _strategy.RunCommand(rover);

            Assert.Equal(CompassCardinalPoint.E, rover.Orientation);
        }

        [Fact]
        public void RunCommand_RoverOrientationEastTurnLeft_ReturnRoverOrientationNorth()
        {
            Rover rover = new Rover(1, 2, "E");

            _strategy.RunCommand(rover);

            Assert.Equal(CompassCardinalPoint.N, rover.Orientation);
        }
    }
}