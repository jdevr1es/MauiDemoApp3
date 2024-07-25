using MauiDemoApp3.ViewModel;
using MauiDemoApp3.Model;

namespace MauiDemoApp3.View
{
    public partial class MainPage : ContentPage
    {

        private MainViewModel vm = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.FullName = "John DeVries";
            

        }

    }

}
