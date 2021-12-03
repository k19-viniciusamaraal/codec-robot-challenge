using System;

namespace CodecRobotChallenge.Domain
{
    public class Terrain : ITerrain
    {
        private readonly long _xMin;
        private readonly long _xMax;
        private readonly long _yMin;
        private readonly long _yMax;

        public Terrain(long xMax, long yMax)
        {
            _xMin = _yMin = 1;
            _xMax = xMax;
            _yMax = yMax;
        }

        public bool IsItPossibleToMoveForward(IRobot robot)
        {
            switch (robot.CurrentDirection)
            {
                case RobotDirection.North:
                    return robot.PositionY < _yMax;
                case RobotDirection.East:
                    return robot.PositionX < _xMax;
                case RobotDirection.South:
                    return robot.PositionY > _yMin;
                case RobotDirection.West:
                    return robot.PositionX > _xMin;
                default:
                    throw new ArgumentException("Invalid movement!");
            }
        }
    }
}
