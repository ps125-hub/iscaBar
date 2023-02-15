using iscaBar.Models;
using iscaBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iscaBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailOrderView : ContentPage
    {
        private Boolean nou;
        private DetailOrderViewVM detailOrderViewVM;
        public DetailOrderViewVM DetailOrderViewVM { get { return detailOrderViewVM; } set { detailOrderViewVM = value; OnPropertyChanged(); } }
        public DetailOrderView(Order order,Boolean nou)
        {
            InitializeComponent();
            DetailOrderViewVM = new DetailOrderViewVM(order);
            this.nou = nou;
            this.BindingContext = DetailOrderViewVM;
        }


        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ClickedGuardar(object sender, EventArgs e)
        {
            if (!nou)
            {
                updateOrder();
            }
            else
            {
                addOrder();
            }
        }
        private async Task addOrder()
        {
            detailOrderViewVM.addOrder();
        }
        private async Task updateOrder()
        {
            detailOrderViewVM.updateOrder();
        }
        private void ClickedLimpiar(object sender, EventArgs e)
        {
            detailOrderViewVM.Order = new Order();
        }

        private void ClickedAddLine(object sender, EventArgs e)
        {

        }

        private void ClickedDeleteLine(object sender, EventArgs e)
        {

        }
    }
}