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
    public class UserManager : IUserService
    {
        private readonly IUserDal userDal;
        private UserValidation validator;
        private ValidationResult result;

        public UserManager(IUserDal userDal)
        {
            validator = new UserValidation();
            this.userDal = userDal;
        }

        public string Add(User entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                userDal.Add(entity);
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
            User deleteUser = userDal.Get(p => p.Id == id);
            userDal.Delete(deleteUser);
            JObject jsonObject = new JObject();
            jsonObject.Add("Status", "success");
            jsonObject.Add("ErrorMessage", "Kayıt başarıyla silindi.");
            JArray array = new JArray();
            array.Add(jsonObject);
            return JsonConvert.SerializeObject(array);
        }

        public User Get(int id)
        {
            return userDal.Get(p => p.Id == id);
        }

        public List<User> GetAll()
        {
            return userDal.GetAll();
        }

        public User GetUsernamePassword(User user)
        {
            return userDal.Get(p => p.UserName == user.UserName && p.Password == user.Password);
        }

        public bool LoginControl(User entity)
        {
            int count = userDal.GetAll(p => p.UserName == entity.UserName && p.Password == entity.Password).Count;
            return count != 0;
        }

        public string Update(User entity)
        {
            result = validator.Validate(entity);
            if (result.IsValid)
            {
                userDal.Update(entity);
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