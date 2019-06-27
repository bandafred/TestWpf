using System.Data.Entity;
using Model;

namespace DomainModel
{
    public class Context : DbContext
    {
        private static readonly string connect = "DataBase";


        public Context() : base(connect)
        {
            Database.SetInitializer(new MyContextInitializer());
        }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}