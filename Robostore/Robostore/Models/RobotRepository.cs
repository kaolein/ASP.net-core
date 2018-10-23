using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robostore.Models
{
    public class RobotRepository: iRobotRepository
    {
        private readonly AppDbContext _appDbContext;

        public RobotRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Robot> Robots
        {
            get
            {
                return _appDbContext.Robots.Include(c => c.Category);
            }
        }

        public IEnumerable<Robot> RobotsOfTheWeek
        {
            get
            {
                return _appDbContext.Robots.Include(c => c.Category).Where(p => p.IsRobotOfTheWeek);
            }
        }

        public Robot GetRobotById(int robotId)
        {
            return _appDbContext.Robots.FirstOrDefault(p => p.RobotId == robotId);
        }

    }
}
