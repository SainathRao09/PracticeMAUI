using PracticeMAUI.Models;
using PracticeMAUI.ViewModels;

namespace PracticeMAUI.Views;

public partial class ProductListPage : ContentPage
{
    ProductListViewModel viewModel;
    public ProductListPage()
	{
		InitializeComponent();
        BindingContext = viewModel = new ProductListViewModel();
    }
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;
        if (selectedProduct != null)
        {
            await Shell.Current.GoToAsync($"productdetail?productId={selectedProduct.Id}");
        }
    }
}