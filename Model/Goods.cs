using System.ComponentModel.DataAnnotations;

namespace Model
{
    /// <summary>
    /// Модель товара.
    /// </summary>
    public class Goods
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Наименование производителя.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        public double Price { get; set; }
    }
}
