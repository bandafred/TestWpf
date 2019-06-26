using System;
using DomainModel;

namespace Model.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context db = new Context();
        private bool disposed = false;


        private GoodsRepository goodsRepository;
        private OrdersRepository ordersRepository;
       

        public GoodsRepository Goods => goodsRepository ?? (goodsRepository = new GoodsRepository(db));
        public OrdersRepository Orders => ordersRepository ?? (ordersRepository = new OrdersRepository(db));

        public void Save()
        {
            db.SaveChanges();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
