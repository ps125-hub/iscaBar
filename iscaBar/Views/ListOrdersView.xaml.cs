using iscaBar.Models;
using iscaBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using iscaBar.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iscaBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOrdersView : ContentPage
    {
        private ListOrdersVM listOrdersVM;
        public ListOrdersVM ListOrdersVM { get { return listOrdersVM; } set { listOrdersVM = value; OnPropertyChanged(); } }

        public ListOrdersView( )
        {
            InitializeComponent();

            ListOrdersVM = new ListOrdersVM();
            this.BindingContext = ListOrdersVM;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Order order = (Order)e.Item;
            if (e.Item == null)
                return;
            
            await Navigation.PushAsync(new DetailOrderView(order));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void OnItemClicked(object sender, EventArgs e)
        {

        }

        private void OnHeaderIconTapped(object sender, EventArgs e)
        {

        }
    }
}