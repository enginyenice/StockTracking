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
    public class StockMovementManager : IStockMovementService
    {
        IStockMovementDal stockMovementDal;
        StockMovementValidation validator;
        ValidationResult result;

        public StockMovementManager(IStockMovementDal stockMovementDal)
        {
            this.stockMovementDal = stockMovementDal;
            validator = new StockMovementValidation();
        }

        public string Add(StockMovement entity)
        {
            
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                stockMovementDal.Add(entity);
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
            StockMovement stockMovement = stockMovementDal.Get(p => p.Id == id);
            stockMovementDal.Delete(stockMovement);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);

        }

        public StockMovement Get(int id)
        {
            return stockMovementDal.Get(p => p.Id == id);
        }

        public List<StockMovement> GetAll()
        {
            return stockMovementDal.GetAll();
        }

        public string Update(StockMovement entity)
        {
           

            result = validator.Validate(entity);
            if (result.IsValid)
            {
                stockMovementDal.Update(entity);
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
