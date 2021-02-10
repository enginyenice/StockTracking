using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductInStoreDal : EfRepositoryBase<ProductInStore, StockTrackingContext>, IProductInStoreDal
    {
        public List<CriticalStockReportDto> CriticalStockReport()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                var result = from productInStore in context.ProductInStores
                             join product in context.Products
                             on productInStore.ProductId equals product.Id
                             join store in context.Stores
                             on productInStore.StoreId equals store.Id
                             select new CriticalStockReportDto
                             {
                                 StoreName = store.Name,
                                 CriticalStock = product.CriticalStock,
                                 ProductName = product.Description,
                                 Stock = productInStore.Stock
                             };
                return result.ToList();
            }
        }
    }
}
