using System;
using System.Collections.Generic;
using System.Text;

namespace CodecRobotChallenge.Domain
{
    public interface ITerrain
    {
        bool IsItPossibleToMoveForward(IRobot robot);
    }
}
