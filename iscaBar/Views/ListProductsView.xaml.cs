using iscaBar.Models;
using iscaBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iscaBar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProductsView : ContentPage
    {
        private ObservableCollection<Item> items;
        public ObservableCollection<Item> Items { get { return items; } set { items = value; OnPropertyChanged(); } }
        private ListProductsVM listProductsVM;
        public ListProductsVM ListProductsVM { get { return listProductsVM; } set { listProductsVM = value; OnPropertyChanged(); } }

        public ListProductsView(/*Category fatherCategory*/ )
        {
           /* Items = new ObservableCollection<Item>();
            Item i1 = new Item();
            i1.Id = "1";
            i1.Text = "item1";
            i1.Description = "Description item1";
            Item i2 = new Item();
            i2.Id = "2";
            i2.Text = "item2";
            i2.Description = "Description item2";
            Item i3 = new Item();
            i3.Id = "3";
            i3.Text = "item3";
            i3.Description = "Description item3";
            Items.Add(i1);
            Items.Add(i2);
            Items.Add(i3);*/
            InitializeComponent();
            listProductsVM = new ListProductsVM(/*fatherCategory*/);
            this.BindingContext = listProductsVM;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}