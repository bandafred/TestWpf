using System.Data.Entity;
using System.Linq;
using DomainModel;

namespace Model.Repository
{
    public class GoodsRepository : IRepository<Goods>
    {
        private readonly Context db;

        public GoodsRepository(Context context) => this.db = context;

        public void Create(Goods item)
        {
            if (item != null) db.Goods.Add(item);
        }

        public void Delete(int id)
        {
            var item = db.Goods.Find(id);
            if (item != null)
                db.Goods.Remove(item);
        }

        public Goods Get(int id)
        {
            return db.Goods.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Goods> GetAll()
        {
            return db.Goods.AsNoTracking();
        }

        public void Update(Goods item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
