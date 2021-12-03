using CodecRobotChallenge.Domain;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace UnitTests.Domain.RobotTests
{
    public class TurnTests
    {
        private readonly AutoMocker _mocker;
        private readonly Mock<ITerrain> _terrainMock;

        public TurnTests()
        {
            _mocker = new AutoMocker();
            _terrainMock = _mocker.GetMock<ITerrain>();
        }

        [Fact]
        public void WhenTurningLeftFromNorth_ShouldTurntoWest()
        {
            var robot = new Robot(initialDirection: RobotDirection.North);

            robot.Turn(RobotMovement.Left);

            Assert.Equal(RobotDirection.West, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningRightFromNorth_ShouldTurntoEast()
        {
            var robot = new Robot(initialDirection: RobotDirection.North);

            robot.Turn(RobotMovement.Right);

            Assert.Equal(RobotDirection.East, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningLeftFromEast_ShouldTurntoNorth()
        {
            var robot = new Robot(initialDirection: RobotDirection.East);

            robot.Turn(RobotMovement.Left);

            Assert.Equal(RobotDirection.North, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningRightFromEast_ShouldTurntoSouth()
        {
            var robot = new Robot(initialDirection: RobotDirection.East);

            robot.Turn(RobotMovement.Right);

            Assert.Equal(RobotDirection.South, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningLeftFromSouth_ShouldTurntoEast()
        {
            var robot = new Robot(initialDirection: RobotDirection.South);

            robot.Turn(RobotMovement.Left);

            Assert.Equal(RobotDirection.East, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningRightFromSouth_ShouldTurntoWest()
        {
            var robot = new Robot(initialDirection: RobotDirection.South);

            robot.Turn(RobotMovement.Right);

            Assert.Equal(RobotDirection.West, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningLeftFromWest_ShouldTurntoSouth()
        {
            var robot = new Robot(initialDirection: RobotDirection.West);

            robot.Turn(RobotMovement.Left);

            Assert.Equal(RobotDirection.South, robot.CurrentDirection);
        }

        [Fact]
        public void WhenTurningRightFromWest_ShouldTurntoNorth()
        {
            var robot = new Robot(initialDirection: RobotDirection.West);

            robot.Turn(RobotMovement.Right);

            Assert.Equal(RobotDirection.North, robot.CurrentDirection);
        }
    }
}
