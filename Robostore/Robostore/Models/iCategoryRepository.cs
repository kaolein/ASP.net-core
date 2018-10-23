using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Robostore.Models
{
    public interface iCategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
