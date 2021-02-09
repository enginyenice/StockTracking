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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        CustomerValidation validator;
        ValidationResult result;
        public CustomerManager(ICustomerDal customerDal)
        {
            validator = new CustomerValidation();
            this.customerDal = customerDal;
        }

        public string Add(Customer entity)
        {

            result = validator.Validate(entity);
            if (result.IsValid)
            {
                customerDal.Add(entity);
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
            Customer deleteCustomer = customerDal.Get(p => p.Id == id);
            customerDal.Delete(deleteCustomer);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);
        }

        public Customer Get(int id)
        {
            return customerDal.Get(p => p.Id == id);
        }

        public List<Customer> GetAll()
        {
            return customerDal.GetAll();
        }

        public string Update(Customer entity)
        {
            
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                customerDal.Update(entity);
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
