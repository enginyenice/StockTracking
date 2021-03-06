﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();

        User Get(int id);

        User GetUsernamePassword(User user);

        string Add(User entity);

        string Delete(int id);

        string Update(User entity);

        bool LoginControl(User entity);
    }
}