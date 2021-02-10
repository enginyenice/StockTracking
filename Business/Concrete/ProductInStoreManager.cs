using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductInStoreManager : IProductInStoreService
    {
        IProductInStoreDal productInStoreDal;
        ProductInStoreValidation validator;
        ValidationResult result;

        public ProductInStoreManager(IProductInStoreDal productInStoreDal)
        {
            validator = new ProductInStoreValidation();
            this.productInStoreDal = productInStoreDal;
        }

        public string Add(ProductInStore entity)
        {
           

            result = validator.Validate(entity);
            if (result.IsValid)
            {
                productInStoreDal.Add(entity);
                JObject jsonObject = new JObject();
                jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Kayıt başarıyla oluşturuldu");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);

            }
            else
            {
                return JsonConvert.SerializeObject(result.Errors);
            }
        }

        public List<CriticalStockReportDto> CriticalStockReport()
        {
            return productInStoreDal.CriticalStockReport();
        }

        public string Delete(int id)
        {
            ProductInStore productInStore = productInStoreDal.Get(p => p.Id == id);
            productInStoreDal.Delete(productInStore);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);

           
            
        }

        public ProductInStore Get(int id)
        {
            return productInStoreDal.Get(p => p.Id == id);
        }

        public List<ProductInStore> GetAll()
        {
            return productInStoreDal.GetAll();
        }

        public List<ProductInStore> GetAllStore(int ProductId)
        {
            return productInStoreDal.GetAll(p => p.ProductId == ProductId);
        }

        public ProductInStore GetStoreCount(int storeId, int ProductId)
        {
            return productInStoreDal.Get(m => m.StoreId == storeId && m.ProductId == ProductId);
        }

        public string Transfer(int storeID, int storeTransferId, int ProductId, int Count)
        {
            try
            {
                var FirstStore = productInStoreDal.Get(p => p.StoreId == storeID && p.ProductId == ProductId);
                //var LastStore = productInStoreDal.Get(p => p.StoreId == storeID && p.ProductId == ProductId);

                ProductInStore transferControlData = productInStoreDal.Get(p => p.StoreId == storeTransferId && p.ProductId == ProductId);
                if(transferControlData == null)
                {
                    ProductInStore LastStoreNew = new ProductInStore { ProductId = ProductId, StoreId = storeTransferId, Stock = Count };
                    productInStoreDal.Add(LastStoreNew);
                } else
                {
                    var LastStore = productInStoreDal.Get(p => p.StoreId == storeTransferId && p.ProductId == ProductId);
                    LastStore.Stock = LastStore.Stock + Count;
                    productInStoreDal.Update(LastStore);
                }
                FirstStore.Stock = FirstStore.Stock - Count;
                productInStoreDal.Update(FirstStore);

                JObject jsonObject = new JObject();
                jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Transfer başarıyla tamamlandı");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);

            }
            catch (Exception)
            {

                JObject jsonObject = new JObject();
                //jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Transfer gerçekleştirilemedi. Tekrar deneyiniz...");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);
            }
        }

        public string Update(ProductInStore entity)
        {

            result = validator.Validate(entity);
            if (result.IsValid)
            {
                productInStoreDal.Update(entity);
                JObject jsonObject = new JObject();
                jsonObject.Add("Status", "success");
                jsonObject.Add("ErrorMessage", "Kayıt başarıyla güncellendi");
                JArray array = new JArray();
                array.Add(jsonObject);
                return JsonConvert.SerializeObject(array);

            }
            else
            {
                return JsonConvert.SerializeObject(result.Errors);
            }

            
        }
    }
}
