using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();

        Supplier Get(int id);

        string Add(Supplier entity);

        string Delete(int id);

        string Update(Supplier entity);
    }
}