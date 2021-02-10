using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        private ProductValidation validator;
        private ValidationResult result;

        public ProductManager(IProductDal productDal)
        {
            validator = new ProductValidation();
            this.productDal = productDal;
        }

        public string Add(Product entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                productDal.Add(entity);
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
            Product deleteProduct = productDal.Get(p => p.Id == id);
            productDal.Delete(deleteProduct);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);
        }

        public Product Get(int id)
        {
            return productDal.Get(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public string Update(Product entity)
        {
            if (result.IsValid)
            {
                productDal.Update(entity);
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