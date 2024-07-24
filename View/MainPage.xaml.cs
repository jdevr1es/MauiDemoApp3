using MauiDemoApp3.ViewModel;

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
            vm.FavoriteFlower = "pic_trulli.jpg";

        }

    }

}
