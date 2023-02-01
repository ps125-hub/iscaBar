using iscaBar.Models;
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
        public DetailOrderView(Order order)
        {
            InitializeComponent();
        }

        private void ClickedModificar(object sender, EventArgs e)
        {

        }

        private void ClickedEsborra(object sender, EventArgs e)
        {

        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}