using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product Get(int id);

        string Add(Product entity);

        string Delete(int id);

        string Update(Product entity);
    }
}