using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal supplierDal;
        SupplierValidation validator;
        ValidationResult result;

        public SupplierManager(ISupplierDal supplierDal)
        {
            validator = new SupplierValidation();
            this.supplierDal = supplierDal;
        }

        public string Add(Supplier entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                supplierDal.Add(entity);
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
            Supplier deleteSupplier = supplierDal.Get(p => p.Id == id);
            supplierDal.Delete(deleteSupplier);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);
        }

        public Supplier Get(int id)
        {
            return supplierDal.Get(p => p.Id == id);
        }

        public List<Supplier> GetAll()
        {
            return supplierDal.GetAll();
        }

        public string Update(Supplier entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                supplierDal.Update(entity);
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
