using MauiDemoApp3.ViewModel;

namespace MauiDemoApp3.View;

public partial class LoginPage : ContentPage
{
    private LoginViewModel vm = new LoginViewModel();
    public LoginPage()
	{
		InitializeComponent();
        BindingContext = vm;
    }
}