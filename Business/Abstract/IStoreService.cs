using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IStoreService
    {
        List<Store> GetAll();
        Store Get(int id);
        string Add(Store entity);
        string Delete(int id);
        string Update(Store entity);
    }
}
