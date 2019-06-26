using System.Collections.Generic;
using System.Linq;
using Model.Repository;

namespace ViewModel
{
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
