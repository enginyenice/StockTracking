using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStoreService
    {
        List<Store> GetAll();

        Store Get(int id);

        string Add(Store entity);

        string Delete(int id);

        string Update(Store entity);

        List<Store> GetAllOrderStore(int id);
    }
}