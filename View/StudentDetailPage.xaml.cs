namespace MauiDemoApp3.View;
using MauiDemoApp3.ViewModel;

public partial class StudentDetailPage : ContentPage
{

	StudentDetailViewModel vm = new StudentDetailViewModel();
	public StudentDetailPage()
	{
		InitializeComponent();
        BindingContext = vm;
    }
}