using System;

namespace ViewModel
{
    /// <summary>
    /// Вью-модель заказа.
    /// </summary>
    public class OrdersModel
    {
        /// <summary>
        /// Дата заказа.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        public string NameGoods { get; set; }

        /// <summary>
        /// Наименование производителя.
        /// </summary>
        public string NameManufacturer { get; set; }

        /// <summary>
        /// Количество товара.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        public Double Summ { get; set; }
    }
}
