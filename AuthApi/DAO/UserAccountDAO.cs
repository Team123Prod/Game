﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthApi.Models;

namespace AuthApi.DAO
{
    public class UserAccountDAO
    {
        public void Create(UserAccount p)
        {
            using (GameDbContext context = new GameDbContext())
            {
                context.UserAccount.Add(p);
                context.SaveChanges();
            }
        }

        public void Delete(UserAccount p)
        {
            using (GameDbContext context = new GameDbContext())
            {
                UserAccount pToDel = context.UserAccount.First(x => x.Id == p.Id);
                context.UserAccount.Remove(pToDel);
                context.SaveChanges();
            }
        }

        public List<UserAccount> Read()
        {
            using (GameDbContext context = new GameDbContext())
            {
                return context.UserAccount.ToList();
            }
        }

        public void Update(UserAccount p)
        {
            using (GameDbContext context = new GameDbContext())
            {
                UserAccount original = context.UserAccount.FirstOrDefault(x => x.Id == p.Id);
                context.Entry(original).CurrentValues.SetValues(p);
                context.SaveChanges();
            }
        }
    }
}