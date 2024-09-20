using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiDemoApp3.Model
{
    [ObservableObject]
    public partial class Student
    {
        public string Id { get; set; }

        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public bool isRegistered;
    }
}
