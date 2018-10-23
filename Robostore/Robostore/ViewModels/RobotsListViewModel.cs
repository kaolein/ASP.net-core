using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Robostore.Models;

namespace Robostore.ViewModels
{
    public class RobotsListViewModel
    {
        public IEnumerable<Robot> Robots { get; set; }
        public string CurrentCategory { get; set; }

    }
}
