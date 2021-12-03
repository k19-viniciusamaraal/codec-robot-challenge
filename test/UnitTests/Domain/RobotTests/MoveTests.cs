using CodecRobotChallenge.Domain;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace UnitTests.Domain.RobotTests
{
    public class MoveTests
    {
        private readonly AutoMocker _mocker;
        private readonly Mock<ITerrain> _terrainMock;

        public MoveTests()
        {
            _mocker = new AutoMocker();
            _terrainMock = _mocker.GetMock<ITerrain>();
        }

        [Fact]
        public void WhenIsPossibleToMoveAndRobotIsFacingNorth_ShouldMoveToNorth()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(true);

            var robot = new Robot();
            robot.Move(_terrainMock.Object);

            Assert.Equal(1, robot.PositionX);
            Assert.Equal(2, robot.PositionY);
        }

        [Fact]
        public void WhenIsPossibleToMoveAndFacingEast_ShouldMoveToEast()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(true);
            var robot = new Robot(initialDirection: RobotDirection.East);
            
            robot.Move(_terrainMock.Object);

            Assert.Equal(2, robot.PositionX);
            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void WhenIsPossibleToMoveAndFacingSouth_ShouldMoveToSouth()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(true);
            var robot = new Robot(
                initialX: 1,
                initialY: 2,
                initialDirection: RobotDirection.South);

            robot.Move(_terrainMock.Object);

            Assert.Equal(1, robot.PositionX);
            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void WhenIsPossibleToMoveAndFacingWest_ShouldMoveToWest()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(true);
            var robot = new Robot(
                initialX: 2,
                initialY: 1,
                initialDirection: RobotDirection.West);

            robot.Move(_terrainMock.Object);

            Assert.Equal(1, robot.PositionX);
            Assert.Equal(1, robot.PositionY);
        }

        [Fact]
        public void WhenItIsNotPossibleToMoveAndRobotIsFacingNorth_ShouldMoveToNorth()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(false);

            var robot = new Robot(
                initialX: 2, 
                initialY: 2,
                initialDirection: RobotDirection.North);
            robot.Move(_terrainMock.Object);

            Assert.Equal(2, robot.PositionX);
            Assert.Equal(2, robot.PositionY);
        }

        [Fact]
        public void WhenItIsNotPossibleToMoveAndRobotIsFacingEast_ShouldMoveToEast()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(false);

            var robot = new Robot(
                initialX: 2,
                initialY: 2,
                initialDirection: RobotDirection.East);
            robot.Move(_terrainMock.Object);

            Assert.Equal(2, robot.PositionX);
            Assert.Equal(2, robot.PositionY);
        }

        [Fact]
        public void WhenItIsNotPossibleToMoveAndRobotIsFacingSouth_ShouldMoveToSouth()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(false);

            var robot = new Robot(
                initialX: 2,
                initialY: 2,
                initialDirection: RobotDirection.South);
            robot.Move(_terrainMock.Object);

            Assert.Equal(2, robot.PositionX);
            Assert.Equal(2, robot.PositionY);
        }

        [Fact]
        public void WhenItIsNotPossibleToMoveAndRobotIsFacingWest_ShouldMoveToWest()
        {
            _terrainMock.Setup(x => x.IsItPossibleToMoveForward(It.IsAny<IRobot>())).Returns(false);

            var robot = new Robot(
                initialX: 2,
                initialY: 2,
                initialDirection: RobotDirection.West);
            robot.Move(_terrainMock.Object);

            Assert.Equal(2, robot.PositionX);
            Assert.Equal(2, robot.PositionY);
        }
    }
}
