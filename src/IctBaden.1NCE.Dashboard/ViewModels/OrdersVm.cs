using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IctBaden.Api1NCE;
using IctBaden.Api1NCE.Models;
using IctBaden.Stonehenge3.Core;
using IctBaden.Stonehenge3.ViewModel;
// ReSharper disable MemberCanBePrivate.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class OrdersVm : ActiveViewModel
    {
        public List<Order> Orders => GetOrders();


        public OrdersVm(AppSession session) : base(session)
        {
        }

        private List<Order> _orders;
        private List<Order> GetOrders()
        {
            if (_orders != null)
            {
                return _orders;
            }
            
            _orders = new List<Order>
            {
                new Order { OrderType = "loading..." }
            };

            Task.Run(() =>
            {
                try
                {
                    var ordersV1 = new OrdersV1(DefaultUrls.Api, Program.ApiToken);
                    _orders = ordersV1.GetOrders()
                        .OrderBy(order => order.OrderNumber)
                        .ToList();
                }
                catch (Exception ex)
                {
                    _orders = new List<Order>
                    {
                        new Order { OrderType = ex.Message }
                    };
                }
                    
                NotifyPropertyChanged(nameof(Orders));
            });

            return _orders;
        }
        
    }
}
