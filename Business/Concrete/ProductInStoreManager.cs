using Business.Abstract;
using Business.FluentValidation;
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
