﻿using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.AdminRepositories
{
    public interface IAdminRepository
    {
        Admin Login(string email, string password);
        bool UserExsist(string email);
        Admin CheckByToken(string token);
        void UpdateToken(int id, string token);
    }
    public class AdminRepository : IAdminRepository
    {
        private readonly SpeditoDbContext _context;
        public AdminRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public Admin CheckByToken(string token)
        {
            return _context.Admins.FirstOrDefault(a => a.Token == token);
        }

        public Admin Login(string email, string password)
        {
            Admin admin = _context.Admins.FirstOrDefault(a => a.Email == email);

            if (admin != null && CryptoHelper.Crypto.VerifyHashedPassword(admin.Password, password))
            {
                return admin;
            }

            return null;
        }

        public void UpdateToken(int id, string token)
        {
            Admin admin = _context.Admins.Find(id);

            admin.Token = token;

            _context.SaveChanges();
        }

        public bool UserExsist(string email)
        {
            return _context.Admins.Any(a => a.Email == email);
        }
    }
}
