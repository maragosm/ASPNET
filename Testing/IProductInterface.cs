using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductInterface
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
