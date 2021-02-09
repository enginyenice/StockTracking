using Business.Abstract;
using Business.FluentValidation;
using Business.Ninject;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BuyOrSellManager : IBuyOrSellService
    {
        IProductInStoreDal productInStoreDal;
        IStockMovementDal stockMovementDal;
        
        ProductInStoreValidation validator;
        ValidationResult result;
        StockMovementValidation validator2;
        ValidationResult result2;
        

        public BuyOrSellManager(IStockMovementDal stockMovementDal, IProductInStoreDal productInStoreDal)
        {
            this.stockMovementDal = stockMovementDal;
            this.productInStoreDal = productInStoreDal;
            validator = new ProductInStoreValidation();
            validator2 = new StockMovementValidation();
        }

        public string Buy(ProductInStore productInStore, StockMovement stockMovement)
        {
            result = validator.Validate(productInStore);
            result2 = validator2.Validate(stockMovement);
            if (result.IsValid && result2.IsValid)
            {
                ProductInStore productInStore1 =  productInStoreDal.Get(p => p.ProductId == productInStore.ProductId && p.StoreId == productInStore.StoreId);
                if (productInStore1 == null)
                    productInStoreDal.Add(productInStore);
                else
                {
                    productInStore1.Stock += productInStore.Stock;
                    productInStoreDal.Update(productInStore1);
                        
                }
                stockMovementDal.Add(stockMovement);
                JObject jsonObject = new JObject();
                jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Ürün başarıyla satın alındı.");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);


            } else
            {
                if(!result.IsValid)
                    return JsonConvert.SerializeObject(result.Errors);
                else
                    return JsonConvert.SerializeObject(result2.Errors);
            }



        }

        public string Sell(ProductInStore productInStore, StockMovement stockMovement)
        {
            result = validator.Validate(productInStore);
            result2 = validator2.Validate(stockMovement);
            if (result.IsValid && result2.IsValid)
            {
                ProductInStore productInStore1 = productInStoreDal.Get(p => p.ProductId == productInStore.ProductId && p.StoreId == productInStore.StoreId);
               
                    productInStore1.Stock -= productInStore.Stock;
                    productInStoreDal.Update(productInStore1);
                    stockMovementDal.Add(stockMovement);
                JObject jsonObject = new JObject();
                jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Ürün başarıyla satıldı.");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);
            }
            else
            {
                if (!result.IsValid)
                    return JsonConvert.SerializeObject(result.Errors);
                else
                    return JsonConvert.SerializeObject(result2.Errors);
            }
        }
    }
}
