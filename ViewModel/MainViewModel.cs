using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemoApp3.Model;

namespace MauiDemoApp3.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel
    {
        public MainViewModel()
        {
            StudentList.Add(new Student
            {
                Id = 123,
                Name = "John DeVries",
                IsRegistered = false
            });

            StudentList.Add(new Student
            {
                Id = 234,
                Name = "Jane Doe",
                IsRegistered = false
            });
        }


        [ObservableProperty]
        private bool flowerIsVisible = true;

        [ObservableProperty]
        private string fullName;

        [ObservableProperty]
        private string favoriteFlower = "oip.jpg";

        [RelayCommand]
        private void ToggleFlowerVisibility()
        {
            FlowerIsVisible = !FlowerIsVisible;
        }

        public ObservableCollection<Student> StudentList { get; } = new();

        [RelayCommand]
        void UpdateRegistrations()
        {
            foreach (var item in StudentList)
                item.IsRegistered = true;
        }


    }



}
