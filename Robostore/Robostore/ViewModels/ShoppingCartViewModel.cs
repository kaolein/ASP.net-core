﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Robostore.Models;

namespace Robostore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public int ShoppingCartTotal { get; set; }
    }
}
