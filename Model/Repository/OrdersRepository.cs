using System.Data.Entity;
using System.Linq;
using DomainModel;

namespace Model.Repository
{
    public class OrdersRepository : IRepository<Order>
    {
        private readonly Context db;

        public OrdersRepository(Context context) => this.db = context;

        public void Create(Order item)
        {
            if (item != null) db.Orders.Add(item);
        }

        public void Delete(int id)
        {
            var item = db.Orders.Find(id);
            if (item != null)
                db.Orders.Remove(item);
        }

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Order> GetAll()
        {
            return db.Orders.AsNoTracking();
        }

        public void Update(Order item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
