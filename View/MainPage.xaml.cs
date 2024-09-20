using MauiDemoApp3.ViewModel;
using MauiDemoApp3.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Xml.Linq;


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
            //vm.FullName = "John DeVries";


        }

        //void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string currentStudent = (e.CurrentSelection.FirstOrDefault() as Student)?.Id;
        //    Shell.Current.GoToAsync( $"{nameof(StudentDetailPage)}?id={Id}");


        //}


    }

}
