using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer Get(int id);

        string Add(Customer entity);

        string Delete(int id);

        string Update(Customer entity);
    }
}