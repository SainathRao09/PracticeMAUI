namespace PracticeMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("productdetail", typeof(Views.ProductDetailPage));
        }
    }
}
