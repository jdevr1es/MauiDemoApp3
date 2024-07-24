using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiDemoApp3.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel
    {

        [ObservableProperty]
        private bool flowerIsVisible = true;

        [ObservableProperty]
        private string fullName;

        [ObservableProperty]
        private string favoriteFlower;

        [RelayCommand]
        private void ToggleFlowerVisibility()
        {
            FlowerIsVisible = !FlowerIsVisible;
        }

    }



}
