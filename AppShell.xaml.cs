using MauiDemoApp3.View;

namespace MauiDemoApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("studentdetailpage",
            typeof(StudentDetailPage));
        }
    }
}
