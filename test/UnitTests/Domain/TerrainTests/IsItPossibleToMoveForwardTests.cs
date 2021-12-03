using CodecRobotChallenge.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.Domain.TerrainTests
{
    public class IsItPossibleToMoveForwardTests
    {
        [Fact]
        public void WhenRobotIsNotOnLimitToNorth_ShouldAllowMovingToNorth()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 1, initialDirection: RobotDirection.North);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.True(allowed);
        }

        [Fact]
        public void WhenRobotIsOnLimitToNorth_ShouldNotAllowMovingToNorth()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 2, initialDirection: RobotDirection.North);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.False(allowed);
        }

        [Fact]
        public void WhenRobotIsNotOnLimitToEast_ShouldAllowMovingToEast()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 1, initialDirection: RobotDirection.East);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.True(allowed);
        }

        [Fact]
        public void WhenRobotIsOnLimitToEast_ShouldNotAllowMovingToEast()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 2, initialY: 1, initialDirection: RobotDirection.East);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.False(allowed);
        }

        [Fact]
        public void WhenRobotIsNotOnLimitToSouth_ShouldAllowMovingToSouth()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 2, initialDirection: RobotDirection.South);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.True(allowed);
        }

        [Fact]
        public void WhenRobotIsOnLimitToSouth_ShouldNotAllowMovingToSouth()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 1, initialDirection: RobotDirection.South);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.False(allowed);
        }

        [Fact]
        public void WhenRobotIsNotOnLimitToWest_ShouldAllowMovingToWest()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 2, initialY: 1, initialDirection: RobotDirection.West);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.True(allowed);
        }

        [Fact]
        public void WhenRobotIsOnLimitToWest_ShouldNotAllowMovingToWest()
        {
            var terrain = new Terrain(xMax: 2, yMax: 2);
            var robot = new Robot(initialX: 1, initialY: 1, initialDirection: RobotDirection.West);

            bool allowed = terrain.IsItPossibleToMoveForward(robot);

            Assert.False(allowed);
        }
    }
}
