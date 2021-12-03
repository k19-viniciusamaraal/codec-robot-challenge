using CodecRobotChallenge.Domain;
using System;

namespace CodecRobotChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int terrainMaxX, terrainMaxY;
            string[] terrainDimensions = args[0].Split('x');
            int.TryParse(terrainDimensions[0], out terrainMaxX);
            int.TryParse(terrainDimensions[1], out terrainMaxY);

            string commands = args[1];

            ITerrain mars = new Terrain(terrainMaxX, terrainMaxY);
            IRobot robot = new Robot();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        robot.Turn(RobotMovement.Left);
                        break;
                    case 'R':
                        robot.Turn(RobotMovement.Right);
                        break;
                    case 'F':
                        robot.Move(mars);
                        break;
                    default:
                        throw new ArgumentException($"This Command {commands[i]} is invalid!");
                }
            }

            Console.WriteLine($"{robot.PositionX};{robot.PositionY};{robot.CurrentDirection}");
        }
    }
}
