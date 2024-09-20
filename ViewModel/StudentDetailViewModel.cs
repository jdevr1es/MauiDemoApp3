using System;
using System.Collections.Generic;
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
    [QueryProperty(nameof(Id), "Id")]
    public partial class StudentDetailViewModel
    {
        [ObservableProperty]
        string id;

        
    }
}
