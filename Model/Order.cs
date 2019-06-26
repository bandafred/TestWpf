using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    /// <summary>
    /// Модель заказа.
    /// </summary>
    public class Order
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор товара.
        /// </summary>
        public int GoodsId { get; set; }

        /// <summary>
        /// Количество товара.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Дата заказа.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
