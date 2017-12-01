using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AuthApi.Models;

namespace AuthApi.DAO
{
    public class GameDbContext:DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }
        public GameDbContext(): base("DbFileConnection")
        {
        }
    }
}