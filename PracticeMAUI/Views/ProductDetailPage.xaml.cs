using PracticeMAUI.Models;
using PracticeMAUI.ViewModels;

namespace PracticeMAUI.Views;

[QueryProperty(nameof(ProductId), "productId")]
public partial class ProductDetailPage : ContentPage
{
    public int ProductId { get; set; }
    public ProductDetailPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        BindingContext = new ProductDetailViewModel(ProductId);
    }
}