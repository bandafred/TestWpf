using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DomainModel
{
    public class Context : DbContext
    {
        private static readonly string connect = "DataBase";

        public Context() : base(connect)
        {
        }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}