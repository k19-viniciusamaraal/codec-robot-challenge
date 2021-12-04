using CodecRobotChallenge.Infra.Extensions;
using System;

namespace CodecRobotChallenge.Domain
{
    public class Robot : IRobot
    {
        public RobotDirection CurrentDirection { get; private set; }
        public long PositionX { get; private set; }
        public long PositionY { get; private set; }

        public Robot(long initialX = 1, long initialY = 1, RobotDirection initialDirection = RobotDirection.North)
        {
            CurrentDirection = initialDirection;
            PositionX = initialX;
            PositionY = initialY;
        }

        public void Move(ITerrain terrain)
        {
            if (terrain.IsItPossibleToMoveForward(this))
            {
                switch (CurrentDirection)
                {
                    case RobotDirection.North:
                        PositionY++;
                        break;
                    case RobotDirection.East:
                        PositionX++;
                        break;
                    case RobotDirection.South:
                        PositionY--;
                        break;
                    case RobotDirection.West:
                        PositionX--;
                        break;
                    default:
                        throw new ArgumentException("Invalid direction.");
                }
            }
        }

        public void Turn(RobotMovement moveTo)
        {
            CurrentDirection = moveTo == RobotMovement.Left ? CurrentDirection.GetPrevious() : CurrentDirection.GetNext();
        }
    }
}
