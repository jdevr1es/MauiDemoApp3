using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoApp3.Model
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRegistered { get; set; }
    }
}
