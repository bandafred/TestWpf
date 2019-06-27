using System;
using System.Collections.Generic;
using System.Data.Entity;
using DomainModel;

namespace Model
{
    /// <summary>
    /// Инициализация БД начальными данными.
    /// </summary>
    public class MyContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            var listGoods = new List<Goods>()
            {
                new Goods {Name = "Galaxy S5", Price = 14000, Manufacturer = "Samsung"},
                new Goods {Name = "Процессор FX-8320 OEM", Price = 4000, Manufacturer = "AMD"},
                new Goods {Name = "Процессор Ryzen 7 2700 OEM", Price = 18799, Manufacturer = "AMD"},
                new Goods {Name = "Процессор Core i7-9700 OEM", Price = 27499, Manufacturer = "Intel"},
                new Goods {Name = "Процессор Xeon E5-1660 v4 OEM", Price = 22000, Manufacturer = "Intel"},
                new Goods {Name = "Видеокарта GeForce GTX 1660 Ti", Price = 24000, Manufacturer = "MSI"},
                new Goods {Name = "Видеокарта GeForce RTX 2060", Price = 34000, Manufacturer = "Palit"},
                new Goods {Name = "Видеокарта GeForce RTX 2070", Price = 37499, Manufacturer = "MSI"},
                new Goods {Name = "Видеокарта GeForce RTX 2080", Price = 49599, Manufacturer = "Palit"},
                new Goods {Name = "Видеокарта GeForce RTX 2080 Ti", Price = 14000, Manufacturer = "GIGABYTE"}
            };

            foreach (var item in listGoods)
            {
                db.Goods.Add(item);
            }

            var listOrders = new List<Order>()
            {
                new Order {Date = DateTime.Now, GoodsId = 3, Count = 2},
                new Order {Date = DateTime.Now, GoodsId = 4, Count = 1},
                new Order {Date = DateTime.Now, GoodsId = 1, Count = 2},
                new Order {Date = DateTime.Now, GoodsId = 2, Count = 1},
                new Order {Date = DateTime.Now, GoodsId = 10, Count = 3},
            };

            foreach (var item in listOrders)
            {
                db.Orders.Add(item);
            }

            db.SaveChanges();
        }
    }
}
