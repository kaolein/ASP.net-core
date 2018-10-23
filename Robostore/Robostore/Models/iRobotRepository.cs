using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Robostore.Models
{
    public interface iRobotRepository
    {
        IEnumerable<Robot> Robots { get; }
        IEnumerable<Robot> RobotsOfTheWeek { get; }
        Robot GetRobotById(int robotId);

    }
}
