using iscaBar.DAO.Servidor;
using iscaBar.Model;
using iscaBar.Models;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace iscaBar.ViewModels
{
    public class DetailOrderViewVM:ModelBase
    {
        private List<OrderLine> orderLines;
        public List<OrderLine> OrderLines { get { return orderLines; } set { orderLines = value; OnPropertyChanged(); } }
        private Order order;
        public Order Order { get { return order; } set { order = value; OnPropertyChanged(); } }

        public DetailOrderViewVM(Order o) {
            Order = o;
            OrderLines = o.OrderLine;
        }
        public async Task addOrder()
        {
            OrderSDAO.AddAsync(Order);
        }
        public async Task updateOrder()
        {
            OrderSDAO.UpdateAsync(Order);
        }
        
    }
    
}
