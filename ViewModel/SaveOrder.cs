using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repository;

namespace ViewModel
{
    /// <summary>
    /// Записать заказ в БД.
    /// </summary>
    public class SaveOrder
    {
        private readonly UnitOfWork uow = new UnitOfWork();
        private DateTime date;
        private string nameGoods;
        private int count;

        /// <inheritdoc />
        public SaveOrder(DateTime date, string nameGoods, int count)
        {
            this.date = date;
            this.nameGoods = nameGoods;
            this.count = count;
            Save();
        }

        private void Save()
        {
            var order = new Order();

            order.Date = date;
            order.Count = count;
            order.GoodsId = uow.Goods.GetAll().First(x => x.Name == nameGoods).Id;

            uow.Orders.Create(order);

            uow.Save();
        }
    }
}
