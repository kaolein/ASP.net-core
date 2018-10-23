using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robostore.Models
{
    public class CategoryRepository : iCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
