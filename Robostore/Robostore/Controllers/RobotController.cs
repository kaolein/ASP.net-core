using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robostore.Models;
using Robostore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Robostore.Controllers
{
    public class RobotController : Controller
    {
        private readonly iRobotRepository _robotRepository;
        private readonly iCategoryRepository _categoryRepository;

        public RobotController (iRobotRepository robotRepository, iCategoryRepository categoryRepository)
        {
            _robotRepository = robotRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Robot> robots;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                robots = _robotRepository.Robots.OrderBy(p => p.RobotId);
                currentCategory = "All robots";
            }
            else
            {
                robots = _robotRepository.Robots.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.RobotId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new RobotsListViewModel
            {
                Robots = robots,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var robot = _robotRepository.GetRobotById(id);
            if (robot == null)
                return NotFound();

            return View(robot);
        }
    }
}
