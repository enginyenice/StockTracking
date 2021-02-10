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
    public class StoreManager : IStoreService
    {
        private IStoreDal storeDal;
        private StoreValidation validator;
        private ValidationResult result;

        public StoreManager(IStoreDal storeDal)
        {
            validator = new StoreValidation();
            this.storeDal = storeDal;
        }

        public string Add(Store entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                storeDal.Add(entity);
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
            Store deleteStore = storeDal.Get(p => p.Id == id);
            storeDal.Delete(deleteStore);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);
        }

        public Store Get(int id)
        {
            return storeDal.Get(p => p.Id == id);
        }

        public List<Store> GetAll()
        {
            return storeDal.GetAll();
        }

        public List<Store> GetAllOrderStore(int id)
        {
            return storeDal.GetAll(p => p.Id != id);
        }

        public string Update(Store entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                storeDal.Update(entity);
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