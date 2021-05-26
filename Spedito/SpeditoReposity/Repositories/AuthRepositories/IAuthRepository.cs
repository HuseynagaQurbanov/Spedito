using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Reposities.AuthReposities
{
    public interface IAuthRepository
    {
        User Register(User user);
        User Login(string email, string password);
        bool UserExsist(string email);
        User CheckByToken(string token);
        void UpdateToken(int id, string token);
    }
}
