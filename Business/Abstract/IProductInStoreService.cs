﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductInStoreService
    {
        List<ProductInStore> GetAll();
        List<ProductInStore> GetAllStore(int ProductId);
        ProductInStore Get(int id);
        ProductInStore GetStoreCount(int storeId, int ProductId);
        string Add(ProductInStore entity);
        string Delete(int id);
        string Update(ProductInStore entity);
    }
}
