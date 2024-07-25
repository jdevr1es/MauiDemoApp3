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

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            foreach (var item in vm.StudentList)

                item.IsRegistered = true;
        }
    }

}
