using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robostore.Models;
using Robostore.ViewModels;

namespace Robostore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly iRobotRepository _robotRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(iRobotRepository robotRepository, ShoppingCart shoppingCart)
        {
            _robotRepository = robotRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int robotId)
        {
            var selectedRobot = _robotRepository.Robots.FirstOrDefault(p => p.RobotId == robotId);

            if (selectedRobot != null)
            {
                _shoppingCart.AddToCart(selectedRobot, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int robotId)
        {
            var selectedRobot = _robotRepository.Robots.FirstOrDefault(p => p.RobotId == robotId);

            if (selectedRobot != null)
            {
                _shoppingCart.RemoveFromCart(selectedRobot);
            }
            return RedirectToAction("Index");
        }
    }
}