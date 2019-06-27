using System.Collections.Generic;
using System.Linq;
using Model.Repository;

namespace ViewModel
{
    /// <summary>
    /// Получить все наименования товаров.
    /// </summary>
    public class GetAllNamesGoods
    {
        private readonly UnitOfWork uow = new UnitOfWork();

        public List<string> GetAllNames => GetNames();

        private List<string> GetNames()
        {
            return uow.Goods.GetAll().Select(x =>x.Name).ToList();
        }
    }
}
