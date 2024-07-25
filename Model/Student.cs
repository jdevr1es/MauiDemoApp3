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
        public int Id { get; set; }

        public string Name { get; set; }

        [ObservableProperty]
        public bool isRegistered;
    }
}
