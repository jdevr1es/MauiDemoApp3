using MauiDemoApp3.ViewModel;
using MauiDemoApp3.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


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
