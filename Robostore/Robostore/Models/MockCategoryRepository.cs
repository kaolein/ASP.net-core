using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Robostore.Models
{
    public class MockCategoryRepository: iCategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName= "Колесные", Description="Роботы на колесах"},
                    new Category { CategoryId = 2, CategoryName = "Гусеничные", Description = "Роботы на гусеницах" },
                    new Category { CategoryId = 3, CategoryName = "Шагающие", Description = "Роботы шагающие" },


                };
            }
        }
    }
}
