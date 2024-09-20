using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemoApp3.Model;
using MauiDemoApp3.View;

namespace MauiDemoApp3.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel
    {        
        
        public ObservableCollection<Student> StudentList { get; set; } = new();

        public MainViewModel()
        {
            StudentList.Add(new Student
            {
                Id = "123",
                Name = "John DeVries",
                IsRegistered = false
            });

            StudentList.Add(new Student
            {
                Id = "234",
                Name = "Jane Doe",
                IsRegistered = false
            });

            StudentList.Add(new Student
            {
                Id = "567",
                Name = "Robert Smith",
                IsRegistered = false
            });

            StudentList.Add(new Student
            {
                Id = "432",
                Name = "Mary Roberts",
                IsRegistered = false
            });
        }

        //public ObservableCollection<Student> StudentList { get;set; }

        public Student SelectedItem
        {
            get => this.SelectedItem;
        }



        [RelayCommand]
        void SelectionChanged()
        {

            Shell.Current.GoToAsync("studentdetailpage");

        }



        //[RelayCommand]
        //private void UpdateRegistrations()
        //{
        //    foreach (var item in StudentList)
        //        item.IsRegistered = true;
        //}



        //[ObservableProperty]
        //private string fullName;

        //[ObservableProperty]
        //private bool flowerIsVisible = true;

        //[ObservableProperty]
        //private string favoriteFlower = "oip.jpg";

        //[RelayCommand]
        //private void ToggleFlowerVisibility()
        //{
        //    FlowerIsVisible = !FlowerIsVisible;
        //}





    }



}
