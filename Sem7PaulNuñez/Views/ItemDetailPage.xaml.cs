using Sem7PaulNuñez.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Sem7PaulNuñez.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}