using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DomainModel;
using JetBrains.Annotations;
using Model;
using Model.Repository;
using WpfTest.Infrastructure.Helper;

namespace WpfTest.ViewModels
{
   public class AddOrderViewModel : INotifyPropertyChanged
    {
        private readonly UnitOfWork uow = new UnitOfWork();

        public AddOrderViewModel()
        {
            GoodsList = uow.Goods.GetAll().ToList();
        }


        public DateTime Date { get; set; } = DateTime.Now;

        public List<Goods> GoodsList { get; set; }

        public Goods SelectedGood { get; set; }

        public int Count { get; set; } = 1;


        /// <summary>
        /// Окно не закрывается.
        /// </summary>
        public ICommand CloseWindow => new Command(o =>
        {
            var window = new AddOrderView();
            window.Close();
        });

        public ICommand SaveOrderCommand => new Command(o =>
        {
            var order = new Order();
            order.Date = Date;
            order.GoodsId = SelectedGood.Id;
            order.Count = this.Count;

            uow.Orders.Create(order);
            uow.Save();

            CloseWindow.Execute(null);
        });

        

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
