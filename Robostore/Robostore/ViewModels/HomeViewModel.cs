using Robostore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robostore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Robot> RobotsOfTheWeek { get; set; }
    }
}
