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
    public class EfStockMovementDal : EfRepositoryBase<StockMovement, StockTrackingContext>, IStockMovementDal
    {
        public List<ProductReportDto> GetReportData()
        {
            using (StockTrackingContext context = new StockTrackingContext())
            {
                DateTime date = DateTime.Now;
                var shortDate = date.Date;


                var result = from p in context.StockMovements
                             join c in context.Customers
                             on p.MemberNumber equals c.Id
                             join s in context.Products
                             on p.ProductId equals s.Id
                             join d in context.Suppliers
                             on p.MemberNumber equals d.Id
                             where p.TransactionDate == shortDate
                             select new ProductReportDto
                             {
                                 Id = p.Id,
                                 ProductDetail = "["+s.Id+"] "+s.Description,
                                 FirstName = (p.Type == "Buy") ? d.CompanyName : c.FirstName,
                                 LastName = (p.Type == "Buy") ? "" : c.LastName,
                                 Piece = p.Piece,
                                 TotalPrice = p.TotalPrice,
                                 UnitPrice = p.UnitPrice,
                                 Type = (p.Type == "Buy") ? "Alış" : "Satış",
                                 TransactionDate = p.TransactionDate
                             };

                    return result.ToList();



            }
        }
    }
}
