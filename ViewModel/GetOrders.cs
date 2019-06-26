using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repository;

namespace ViewModel
{
    /// <summary>
    /// Получить заказы.
    /// </summary>
    public class GetOrders
    {
        private readonly UnitOfWork uow = new UnitOfWork();

        public List<OrdersModel> GetAllOrders => GetOrdersAll();

        
        private List<OrdersModel> GetOrdersAll()
        {
            var orders = uow.Orders.GetAll().ToList();
            var goods = uow.Goods.GetAll().ToList();

            var ordersModel = new List<OrdersModel>();
            foreach (var item in orders)
            {
                var orderAdd = new OrdersModel();
                orderAdd.Date = item.Date;
                orderAdd.Count = item.Count;
                orderAdd.NameGoods = goods.First(x => x.Id == item.GoodsId).Name;
                orderAdd.NameManufacturer = goods.First(x => x.Id == item.GoodsId).Manufacturer;
                orderAdd.Summ = Math.Round(item.Count * goods.First(x => x.Id == item.GoodsId).Price, 2);

                ordersModel.Add(orderAdd);
            }

            return ordersModel;
        }
    }
}
