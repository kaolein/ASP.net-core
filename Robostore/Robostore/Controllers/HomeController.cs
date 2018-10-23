using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robostore.Models;
using Robostore.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Robostore.Controllers
{
    public class HomeController : Controller
    {
        private readonly iRobotRepository _robotRepository;

        public HomeController(iRobotRepository robotRepository)
        {
            _robotRepository = robotRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                RobotsOfTheWeek = _robotRepository.RobotsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
