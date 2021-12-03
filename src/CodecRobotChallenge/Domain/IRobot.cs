using System;
using System.Collections.Generic;
using System.Text;

namespace CodecRobotChallenge.Domain
{
    public interface IRobot
    {
        RobotDirection CurrentDirection { get; }
        long PositionX { get; }
        long PositionY { get; }

        void Move(ITerrain terrain);
        void Turn(RobotMovement moveTo);
    }
}
